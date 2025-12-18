using System .Windows;
using System .Windows .Controls;

namespace DomitoryAppDEMO .Views
{
    public partial class SecurityView : UserControl
    {
        public SecurityView ( )
        {
            InitializeComponent();
        }

        private void ManageUsersButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Управление пользователями будет реализовано позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void ManageRolesButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Управление ролями будет реализовано позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void AuditLogButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Просмотр журнала аудита будет реализован позже" ,
                          "В разработке" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void BackupNowButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Резервное копирование выполнено успешно!" ,
                          "Backup" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }
    }
}