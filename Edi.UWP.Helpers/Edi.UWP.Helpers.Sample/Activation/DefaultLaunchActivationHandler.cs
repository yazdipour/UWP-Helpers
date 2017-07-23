using System;
using System.Threading.Tasks;

using Edi.UWP.Helpers.Sample.Services;

using Windows.ApplicationModel.Activation;

namespace Edi.UWP.Helpers.Sample.Activation
{
    internal class DefaultLaunchActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
    {
        private readonly string _navElement;
    
        private NavigationServiceEx NavigationService => Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public DefaultLaunchActivationHandler(Type navElement)
        {
            _navElement = navElement.FullName;
        }
    
        protected override async Task HandleInternalAsync(LaunchActivatedEventArgs args)
        {
            // When the navigation stack isn't restored navigate to the first page,
            // configuring the new page by passing required information as a navigation
            // parameter
            NavigationService.Navigate(_navElement, args.Arguments);

            await Task.CompletedTask;
        }

        protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
        {
            // None of the ActivationHandlers has handled the app activation
            return NavigationService.Frame.Content == null;
        }
    }
}