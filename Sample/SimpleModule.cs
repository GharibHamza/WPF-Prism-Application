using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Sample
{
    public class SimpleModule : IModule
    {
        private IRegionManager _regionManager;

        public SimpleModule(IRegionManager regionManager) {
            _regionManager = regionManager;
        }

        

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("MaRégion", typeof(Views.SampleView));
            //throw new NotImplementedException();
           
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            _regionManager.RegisterViewWithRegion("MaRégion", typeof(Views.SampleView));
            //throw new NotImplementedException();
        }
    }
}
