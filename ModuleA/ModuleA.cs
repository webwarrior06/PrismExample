using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace nsModuleA
{
    public class ModuleA : IModule
    {
        private readonly IRegionManager _rm;

        public ModuleA(IRegionManager region)
        {
            _rm=region;
        }


        public void Initialize()
        {
            _rm.RegisterViewWithRegion("ModuleARegion", typeof (ModuleAView));
        }
    }
}
