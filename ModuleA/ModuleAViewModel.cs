using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Model;
using Microsoft.Practices.Unity;
using Prism.Mvvm;

namespace nsModuleA
{
    public class ModuleAViewModel:BindableBase
    {
        private readonly IUnityContainer _container;
        private readonly IUserInfo _user;
        private readonly IServis _servis;

        private string _adi;
        public string Adi
        {
            get { return _adi; }
            set { SetProperty(ref _adi, value); }
        }


        public ModuleAViewModel(IUnityContainer container, IUserInfo user, IServis servis )
        {
            _container = container;
            _user = user;
            _servis = servis;

            Adi = _user.AdiSoyadi;
        }


    }
}
