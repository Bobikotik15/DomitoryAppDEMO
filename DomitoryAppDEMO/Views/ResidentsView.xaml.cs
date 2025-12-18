using System .Windows;
using System .Windows .Controls;

namespace DomitoryAppDEMO .Views
{
    public partial class ResidentsView : UserControl
    {
        public ResidentsView ( )
        {
            InitializeComponent();
        }

        private void NewResidentButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Добавление нового жильца будет реализовано позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void EditResidentButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Редактирование жильца будет реализовано позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void CheckOutButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Выселение жильца будет реализовано позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void ExportResidentsButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Экспорт данных будет реализован позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void SearchResidentButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Поиск жильца будет реализован позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }
    }
}