using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Windows;

namespace HydropnicDiary.Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private CompositionContainer container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            AggregateCatalog catalog = new AggregateCatalog();

            //catalog.Catalogs.Add(new AssemblyCatalog(typeof(Controller).Assembly));
        }
    }
}
