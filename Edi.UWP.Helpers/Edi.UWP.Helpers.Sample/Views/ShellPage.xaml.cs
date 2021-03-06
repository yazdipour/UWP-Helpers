using System.Data.Common;
using Edi.UWP.Helpers.Sample.Services;
using Edi.UWP.Helpers.Sample.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Edi.UWP.Helpers.Sample.Views
{
    public sealed partial class ShellPage : Page
    {
        private ShellViewModel ViewModel => DataContext as ShellViewModel;

        public ShellPage()
        {
            InitializeComponent();
            DataContext = ViewModel;
            ViewModel.Initialize(shellFrame);
        }
    }
}
