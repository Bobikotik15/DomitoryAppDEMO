using System .Windows;
using System .Windows .Controls;

namespace DomitoryAppDEMO .Views
{
    public partial class SettingsView : UserControl
    {
        public SettingsView ( )
        {
            InitializeComponent();
        }

        private void SaveSettingsButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Настройки успешно сохранены!" ,
                          "Успех" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }

        private void ResetSettingsButton_Click (object sender , RoutedEventArgs e)
        {
            var result = MessageBox .Show("Сбросить все настройки к значениям по умолчанию?" ,
                                        "Подтверждение" ,
                                        MessageBoxButton .YesNo ,
                                        MessageBoxImage .Question);

            if ( result == MessageBoxResult .Yes )
            {
                MessageBox .Show("Настройки сброшены к значениям по умолчанию" ,
                              "Сброс" ,
                              MessageBoxButton .OK ,
                              MessageBoxImage .Information);
            }
        }
    }
}