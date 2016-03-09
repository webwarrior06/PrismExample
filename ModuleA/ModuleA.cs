using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace nsModuleA
{
    public class ModuleA : IModule
    {
        private readonly IUnityContainer _contaier;
        private readonly IRegionManager _rm;
        public ModuleA(IUnityContainer container,IRegionManager region)
        {
            _rm=region;
            _contaier = container;
        }


        public void Initialize()
        {
            _rm.RegisterViewWithRegion("ModuleARegion", typeof (ModuleAView));
        }
    }
}
