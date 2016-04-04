using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Events;
using Infrastructure.Model;
using Microsoft.Practices.Unity;
using nsModuleB;
using Prism.Commands;
using Prism.Events;
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
        private readonly IEventAggregator _aggregator;

        private string _adi;
        public string Adi
        {
            get { return _adi; }
            set { SetProperty(ref _adi, value); }
        }


        public DelegateCommand LoadBModuleCommand { get; }

        public DelegateCommand<string> SetTextCommand { get; } 


        public ModuleAViewModel(IUnityContainer container, IUserInfo user, IServis servis,IModuleManager manager,IEventAggregator aggregator)
        {
            _container = container;
            _user = user;
            _servis = servis;
            _manager = manager;
            _aggregator = aggregator;

            Adi = _user.AdiSoyadi;

            LoadBModuleCommand = new DelegateCommand(LoadBModuleExecute);
            SetTextCommand = new DelegateCommand<string>(SetTextExecute);
        }

        private void SetTextExecute(string obj)
        {
            _aggregator.GetEvent<TextChangedEvent>().Publish(obj);
        }

        private void LoadBModuleExecute()
        {
            _manager.LoadModule(nameof(ModuleB));
        }
    }
}
