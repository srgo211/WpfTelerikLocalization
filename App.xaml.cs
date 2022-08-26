using System.Windows;
using Telerik.Windows.Controls;
using WpfTelerikLocalization.Localization;

namespace WpfTelerikLocalization
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            LocalizationManager.Manager = new LocalizationManager()
            {
                ResourceManager = FilteringUIResources.ResourceManager,
                Culture = new System.Globalization.CultureInfo("ru"),
            };
            //InitializeComponent();

        }
    }
}
