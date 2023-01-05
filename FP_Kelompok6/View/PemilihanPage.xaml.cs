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

namespace FP_Kelompok6.View
{
    /// <summary>
    /// Interaction logic for PemilihanPage.xaml
    /// </summary>
    public partial class PemilihanPage : Page
    {
        public PemilihanPage()
        {
            InitializeComponent();
            combo1.Items.Add("GOPAY");
            combo1.Items.Add("BNI");
            combo1.Items.Add("MANDIRI");
        }

        private void comboBox_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
