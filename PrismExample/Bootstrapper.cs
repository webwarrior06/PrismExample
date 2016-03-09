using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Infrastructure.Model;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using nsModuleA;
using nsModuleB;

namespace PrismExample
{
    public class Bootstrapper : UnityBootstrapper
    {
 
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

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            var moduleAInfo = new ModuleInfo
            {
                InitializationMode = InitializationMode.WhenAvailable,
                ModuleName = typeof (ModuleA).Name,
                ModuleType = typeof (ModuleA).AssemblyQualifiedName
            };

            var moduleBInfo = new ModuleInfo
            {
                InitializationMode = InitializationMode.OnDemand,
                ModuleName = typeof(ModuleB).Name,
                ModuleType = typeof(ModuleB).AssemblyQualifiedName
            };

            ModuleCatalog.AddModule(moduleAInfo);
            ModuleCatalog.AddModule(moduleBInfo);

            var userInfo = new UserInfo {AdiSoyadi = "taha"};

            Container.RegisterInstance<IUserInfo>(userInfo);

            Container.RegisterType<IServis,Servis>(new ContainerControlledLifetimeManager());

        }
    }
}
