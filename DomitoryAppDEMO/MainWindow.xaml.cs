using System;
using System .Collections .Generic;
using System .Windows;
using System .Windows .Controls;
using System .Windows .Input;
using System .Windows .Media;
using DomitoryAppDEMO .Views;

namespace DomitoryAppDEMO
{
    public partial class MainWindow : Window
    {
        private List<Border> menuBorders;

        public MainWindow ( )
        {
            InitializeComponent();
            InitializeMenuBorders();

            // Включение перетаскивания окна
            this .MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
        }
        private void SearchTextBox_TextChanged (object sender , TextChangedEventArgs e)
        {
            // Реализуйте логику поиска здесь
        }
        private void InitializeMenuBorders ( )
        {
            menuBorders = new List<Border>
            {
                DashboardBorder,
                ResidentsBorder,
                RoomsBorder,
                ContractsBorder,
                FinanceBorder,
                MetersBorder,
                ReportsBorder,
                SecurityBorder,
                SettingsBorder
            };
        }

        private void MainWindow_MouseLeftButtonDown (object sender , MouseButtonEventArgs e)
        {
            if ( e .ChangedButton == MouseButton .Left && e .ButtonState == MouseButtonState .Pressed )
                this .DragMove();
        }

        private void Window_Loaded (object sender , RoutedEventArgs e)
        {
            // При загрузке показываем Dashboard
            ShowDashboard();
        }

        // === НАВИГАЦИЯ ===

        private void DashboardButton_Click (object sender , RoutedEventArgs e)
        {
            ShowDashboard();
        }

        private void ResidentsButton_Click (object sender , RoutedEventArgs e)
        {
            ShowResidents();
        }

        private void RoomsButton_Click (object sender , RoutedEventArgs e)
        {
            ShowRooms();
        }

        private void ContractsButton_Click (object sender , RoutedEventArgs e)
        {
            ShowContracts();
        }

        private void FinanceButton_Click (object sender , RoutedEventArgs e)
        {
            ShowFinance();
        }

        private void MetersButton_Click (object sender , RoutedEventArgs e)
        {
            ShowMeters();
        }

        private void ReportsButton_Click (object sender , RoutedEventArgs e)
        {
            ShowReports();
        }

        private void SecurityButton_Click (object sender , RoutedEventArgs e)
        {
            ShowSecurity();
        }

        private void SettingsButton_Click (object sender , RoutedEventArgs e)
        {
            ShowSettings();
        }

        // === МЕТОДЫ ОТОБРАЖЕНИЯ VIEW ===

        private void ShowDashboard ( )
        {
            MainContent .Content = new Views.DashboardView();
            HighlightMenuBorder(DashboardBorder);
        }

        private void ShowResidents ( )
        {
            MainContent .Content = new Views.ResidentsView();
            HighlightMenuBorder(ResidentsBorder);
        }

        private void ShowRooms ( )
        {
            MainContent .Content = new Views .RoomsView();
            HighlightMenuBorder(RoomsBorder);
        }

        private void ShowContracts ( )
        {
            MainContent .Content = new ContractsView();
            HighlightMenuBorder(ContractsBorder);
        }

        private void ShowFinance ( )
        {
            MainContent .Content = new FinanceView();
            HighlightMenuBorder(FinanceBorder);
        }

        private void ShowMeters ( )
        {
            MainContent .Content = new MetersView();
            HighlightMenuBorder(MetersBorder);
        }

        private void ShowReports ( )
        {
            MainContent .Content = new ReportsView();
            HighlightMenuBorder(ReportsBorder);
        }

        private void ShowSecurity ( )
        {
            MainContent .Content = new SecurityView();
            HighlightMenuBorder(SecurityBorder);
        }

        private void ShowSettings ( )
        {
            MainContent .Content = new SettingsView();
            HighlightMenuBorder(SettingsBorder);
        }

        // === ПОДСВЕТКА МЕНЮ ===

        private void HighlightMenuBorder (Border selectedBorder)
        {
            // Цвет для выделения
            var selectedColor = Color .FromArgb(255 , 224 , 231 , 255); // #E0E7FF

            foreach ( var border in menuBorders )
            {
                if ( border != null )
                {
                    // Сбрасываем фон у всех
                    border .Background = Brushes .White;

                    // Сбрасываем жирный шрифт у текста внутри
                    if ( border .Child is Button button &&
                        button .Content is StackPanel stackPanel &&
                        stackPanel .Children .Count > 1 &&
                        stackPanel .Children[1] is TextBlock textBlock )
                    {
                        textBlock .FontWeight = FontWeights .Normal;
                    }
                }
            }

            // Выделяем выбранный
            if ( selectedBorder != null )
            {
                selectedBorder .Background = new SolidColorBrush(selectedColor);

                // Делаем текст жирным
                if ( selectedBorder .Child is Button selectedButton &&
                    selectedButton .Content is StackPanel selectedStackPanel &&
                    selectedStackPanel .Children .Count > 1 &&
                    selectedStackPanel .Children[1] is TextBlock selectedTextBlock )
                {
                    selectedTextBlock .FontWeight = FontWeights .SemiBold;
                }
            }
        }

        // === КНОПКИ УПРАВЛЕНИЯ ОКНОМ ===

        private void MinimizeButton_Click (object sender , RoutedEventArgs e)
        {
            this .WindowState = WindowState .Minimized;
        }

        private void MaximizeButton_Click (object sender , RoutedEventArgs e)
        {
            if ( this .WindowState == WindowState .Maximized )
            {
                this .WindowState = WindowState .Normal;
                MaximizeButton .ToolTip = "Развернуть";
                ((TextBlock)MaximizeButton .Content) .Text = "⬜";
            }
            else
            {
                this .WindowState = WindowState .Maximized;
                MaximizeButton .ToolTip = "Восстановить";
                ((TextBlock)MaximizeButton .Content) .Text = "❐";
            }
        }

        private void CloseButton_Click (object sender , RoutedEventArgs e)
        {
            var result = MessageBox .Show("Вы уверены, что хотите закрыть приложение?" ,
                                        "Подтверждение" ,
                                        MessageBoxButton .YesNo ,
                                        MessageBoxImage .Question);

            if ( result == MessageBoxResult .Yes )
            {
                Application .Current .Shutdown();
            }
        }
    }
}