using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Model;
using Microsoft.Practices.Unity;
using Prism.Mvvm;

namespace nsModuleB
{
    public class ModuleBViewModel:BindableBase
    {
        private readonly IUnityContainer _container;
        private readonly IUserInfo _user;
        private readonly IServis _servis;

        private string _injectedValue;
        [Dependency]
        public string InjectionValue
        {
            get { return _injectedValue; }
            set { SetProperty(ref _injectedValue, value); }
        }

        public ModuleBViewModel(IUnityContainer container, IUserInfo user, IServis servis )
        {
            _container = container;
            _user = user;
            _servis = servis;


           
        }


    }
}
