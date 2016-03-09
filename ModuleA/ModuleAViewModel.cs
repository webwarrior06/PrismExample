using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Model;
using Microsoft.Practices.Unity;
using nsModuleB;
using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;

namespace nsModuleA
{
    public class ModuleAViewModel:BindableBase
    {
        private readonly IUnityContainer _container;
        private readonly IUserInfo _user;
        private readonly IServis _servis;
        private readonly IModuleManager _manager;

        private string _adi;
        public string Adi
        {
            get { return _adi; }
            set { SetProperty(ref _adi, value); }
        }


        public DelegateCommand LoadBModuleCommand { get; } 


        public ModuleAViewModel(IUnityContainer container, IUserInfo user, IServis servis,IModuleManager manager)
        {
            _container = container;
            _user = user;
            _servis = servis;
            _manager = manager;

            Adi = _user.AdiSoyadi;

            LoadBModuleCommand = new DelegateCommand(LoadBModuleExecute);
        }

        private void LoadBModuleExecute()
        {
            _manager.LoadModule(nameof(ModuleB));
        }
    }
}
