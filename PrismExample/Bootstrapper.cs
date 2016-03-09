using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;

namespace PrismExample
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override IUnityContainer CreateContainer()
        {
            return new UnityContainer();
        }

        protected override DependencyObject CreateShell()
        {
            var shell = Container.Resolve<Shell>();
            return shell;
        }

        protected override void InitializeShell()
        {
            //MainWindow'u shell'e atıyoruz. Ama burada göstermeyeceğiz. 
            //Çünkü ilk etapta kullanıcı login ekranını görecek. Eğer login başarılıysa
            //App.xaml.cs içerisinde MainWindow.Show() diyeceğiz.
            Application.Current.MainWindow = (Window)Shell;
        }
    }
}
