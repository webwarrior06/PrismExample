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
using nsModuleB.ViewModels;

namespace nsModuleB.Views
{
    /// <summary>
    /// Interaction logic for Screen2.xaml
    /// </summary>
    public partial class Screen2 : UserControl
    {
        public Screen2()
        {
            InitializeComponent();
            DataContext = new Screen2VM();



        }
    }
}
