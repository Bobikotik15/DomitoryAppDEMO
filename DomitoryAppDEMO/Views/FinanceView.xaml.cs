using System .Windows;
using System .Windows .Controls;

namespace DomitoryAppDEMO .Views
{
    public partial class FinanceView : UserControl
    {
        public FinanceView ( )
        {
            InitializeComponent();
        }

        private void GenerateInvoicesButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Формирование счетов будет реализовано позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void RegisterPaymentButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Регистрация платежей будет реализована позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void ViewDebtorsButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Просмотр должников будет реализован позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }
    }
}