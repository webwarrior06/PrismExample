using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace nsModuleB
{
    public class ModuleB:IModule
    {

        private readonly IUnityContainer _contaier;
        private readonly IRegionManager _rm;
        public ModuleB(IUnityContainer container, IRegionManager region)
        {
            _rm = region;
            _contaier = container;
        }

        public void Initialize()
        {
            _rm.RegisterViewWithRegion("ModuleBRegion", typeof(ModuleBView));

        }
    }
}
