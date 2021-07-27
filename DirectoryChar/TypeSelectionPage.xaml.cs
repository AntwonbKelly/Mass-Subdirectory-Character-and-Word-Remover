using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DirectoryChar
{
    /// <summary>
    /// Interaction logic for TypeSelectionPage.xaml
    /// </summary>
    public partial class TypeSelectionPage : Page
    {
        public TypeSelectionPage()
        {
            InitializeComponent();
        }

        private void SingleCharacterButt_Click(object sender, RoutedEventArgs e)
        {
            SingleCharacterPage newpage = new SingleCharacterPage();
            this.NavigationService.Navigate(newpage);
        }

        private void MultiWordButt_Click(object sender, RoutedEventArgs e)
        {
            DeleteWordPage newpage = new DeleteWordPage();
            this.NavigationService.Navigate(newpage);
        }
    }
}
