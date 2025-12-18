using System .Windows;
using System .Windows .Controls;

namespace DomitoryAppDEMO .Views
{
    public partial class MetersView : UserControl
    {
        public MetersView ( )
        {
            InitializeComponent();
        }

        private void SaveReadingsButton_Click (object sender , RoutedEventArgs e)
        {
            MessageBox .Show("Показания успешно сохранены!" ,
                          "Успех" ,
                          MessageBoxButton .OK ,
                          MessageBoxImage .Information);
        }
    }
}