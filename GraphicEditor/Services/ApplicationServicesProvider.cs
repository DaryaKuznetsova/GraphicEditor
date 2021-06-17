using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccesLayer;
using Persistence.Common;

namespace DemoApp
{

    /// <summary>
    /// Simple service interface
    /// </summary>
    public interface IServiceProvider
    {
        IUIVisualizerService VisualizerService { get; }
        IMessageBoxService MessageBoxService { get; }
        IFileAccessService DatabaseAccessService { get; }
    }


    /// <summary>
    /// Simple service locator
    /// </summary>
    public class ServiceProvider : IServiceProvider
    {
        private IUIVisualizerService visualizerService = new WPFUIVisualizerService();
        private IMessageBoxService messageBoxService = new WPFMessageBoxService();
        private IFileAccessService databaseAccessService = new FileAccessService();

        public IUIVisualizerService VisualizerService
        {
            get { return visualizerService; }
        }

        public IMessageBoxService MessageBoxService
        {
            get { return messageBoxService; }
        }

        public IFileAccessService DatabaseAccessService
        {
            get { return databaseAccessService; }
       }

    }



    /// <summary>
    /// Simple service locator helper
    /// </summary>
    public class ApplicationServicesProvider
    {
        private static Lazy<ApplicationServicesProvider> instance = new Lazy<ApplicationServicesProvider>(() => new ApplicationServicesProvider());
        private IServiceProvider serviceProvider = new ServiceProvider();

        private ApplicationServicesProvider()
        {

        }

        static ApplicationServicesProvider()
        {

        }

        public void SetNewServiceProvider(IServiceProvider provider)
        {
            serviceProvider = provider;
        }

        public IServiceProvider Provider
        {
            get { return serviceProvider; }
        }

        public static ApplicationServicesProvider Instance
        {
            get { return instance.Value;  }
        }
    }
}
