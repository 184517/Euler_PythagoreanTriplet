/* Jordan Ross
* May 31, 2019
* Euler Problem 9
*/
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

namespace Euler_PythagoreanTriplet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int sum = 1000;
        bool found = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            for (a = 1; a < sum / 3; a++)
            {
                for (b = a; b < sum / 2; b++)
                {
                    c = sum - a - b;
                    if (a * a + b * b == c * c && c > b)
                    {
                        found = true;
                        if (found)
                        {
                            lblProduct.Content = a * b * c;
                        }
                        break;
                    }
                }
                
            }
        }
    }
}
