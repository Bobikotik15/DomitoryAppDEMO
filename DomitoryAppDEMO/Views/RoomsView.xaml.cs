using System .Windows;
using System .Windows .Controls;

namespace DomitoryAppDEMO .Views
{
    public partial class RoomsView : UserControl
    {
        public RoomsView ( )
        {
            InitializeComponent();
        }

        private void AllRoomsButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показаны все комнаты" ,
                          "Фильтр" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void FreeRoomsButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показаны свободные комнаты" ,
                          "Фильтр" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void OccupiedRoomsButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показаны занятые комнаты" ,
                          "Фильтр" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void UnderRepairButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показаны комнаты на ремонте" ,
                          "Фильтр" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void Floor1Button_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показан 1 этаж" ,
                          "Этаж" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void Floor2Button_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показан 2 этаж" ,
                          "Этаж" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void Floor3Button_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показан 3 этаж" ,
                          "Этаж" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void Floor4Button_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показан 4 этаж" ,
                          "Этаж" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }
    }
}