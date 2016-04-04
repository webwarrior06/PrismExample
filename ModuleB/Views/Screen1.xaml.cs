using System.Windows.Controls;
using nsModuleB.ViewModels;

namespace nsModuleB.Views
{
    /// <summary>
    /// Interaction logic for Screen1.xaml
    /// </summary>
    public partial class Screen1 : UserControl
    {
        public Screen1()
        {
            InitializeComponent();
            DataContext = new Screen1VM();
        }
    }
}
