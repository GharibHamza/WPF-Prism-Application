using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Modularity;
using Prism.Unity;
using Sample;
using Unity;

namespace WPF1
{
     public class Bootstrapper : UnityBootstrapper
    {
        public override void Run(bool runWithDefaultConfiguration)
        {
            base.Run(runWithDefaultConfiguration);
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();


        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            Type simpleModuleType = typeof(SimpleModule);
            ModuleCatalog.AddModule(new ModuleInfo { ModuleName = simpleModuleType.Name, ModuleType = simpleModuleType.AssemblyQualifiedName });


        }

    }


}
