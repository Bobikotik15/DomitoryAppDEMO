using System .Windows;
using System .Windows .Controls;

namespace DomitoryAppDEMO .Views
{
    public partial class ReportsView : UserControl
    {
        public ReportsView ( )
        {
            InitializeComponent();
        }

        private void DebtorsReportButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Отчёт по должникам будет сформирован" ,
                          "Формирование отчёта" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void FinancialReportButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Финансовый отчёт будет сформирован" ,
                          "Формирование отчёта" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void OccupancyReportButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Отчёт по занятости будет сформирован" ,
                          "Формирование отчёта" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void ServicesReportButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Отчёт по потреблению услуг будет сформирован" ,
                          "Формирование отчёта" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void GenerateReportButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Отчёт успешно сформирован и сохранён!" ,
                          "Отчёт готов" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }
    }
}