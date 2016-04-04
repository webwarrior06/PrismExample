
using System;
using System.Windows.Controls;
using Infrastructure.Events;
using Infrastructure.Model;
using Microsoft.Practices.Unity;
using nsModuleB.Views;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;

namespace nsModuleB
{
    public class ModuleBViewModel:BindableBase
    {
        private readonly IUnityContainer _container;
        private readonly IUserInfo _user;
        private readonly IServis _servis;
        private readonly IEventAggregator _aggregator;
        private readonly IRegionManager _rm;

        private string _injectedValue;
        [Dependency]
        public string InjectionValue
        {
            get { return _injectedValue; }
            set { SetProperty(ref _injectedValue, value); }
        }


        private string _eventResult;
        public string EventResult
        {
            get { return _eventResult; }
            set { SetProperty(ref _eventResult, value); }
        }

        public DelegateCommand<object> NavigateCommand { get; } 

        public ModuleBViewModel(IUnityContainer container, IUserInfo user, IServis servis,IEventAggregator aggregator,IRegionManager rm)
        {
            _container = container;
            _user = user;
            _servis = servis;
            _aggregator = aggregator;
            _rm = rm;

            _aggregator.GetEvent<TextChangedEvent>().Subscribe(TextChangedEventHandler);

            NavigateCommand = new DelegateCommand<object>(NavigateExecute);
        }

        private void NavigateExecute(object param)
        {
            switch (Int32.Parse(param.ToString()))
            {
                case 1:
                    _rm.RequestNavigate("ModuleBInnerRegion", nameof(Screen1));
                    break;
                case 2:
                    _rm.RequestNavigate("ModuleBInnerRegion", nameof(Screen2));

                    break;
            }

        }

        private void TextChangedEventHandler(string text)
        {
            EventResult = text;
        }
    }
}
