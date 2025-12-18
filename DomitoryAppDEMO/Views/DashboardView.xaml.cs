using System .Windows;
using System .Windows .Controls;

namespace DomitoryAppDEMO .Views
{
    public partial class DashboardView : UserControl
    {
        public DashboardView ( )
        {
            InitializeComponent();
        }

        private void NewResidentButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Функция 'Новый жилец' будет реализована в следующем обновлении" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void GenerateInvoicesButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Функция 'Сформировать счета' будет реализована в разделе 'Финансы'" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void EnterReadingsButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Функция 'Ввести показания' будет реализована в разделе 'Счётчики'" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void CreateReportButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Функция 'Создать отчёт' будет реализована в разделе 'Отчёты'" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }
    }
}