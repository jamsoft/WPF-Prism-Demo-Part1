#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.StatusBar
// File Name    : StatusBarModule.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.StatusBar
{
    using Microsoft.Practices.Prism.Modularity;
    using Microsoft.Practices.Prism.Regions;
    using Microsoft.Practices.Unity;

    /// <summary>
    /// The Status bar Module Initializer
    /// </summary>
    [Module(ModuleName = "StatusBarModule", OnDemand = false)]
    public class StatusBarModule : IModule
    {
        /// <summary>The _container</summary>
        private readonly IUnityContainer _container;

        /// <summary>The _region manager</summary>
        private readonly IRegionManager _regionManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusBarModule"/> class.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        /// <param name="regionManager">
        /// The region manager.
        /// </param>
        public StatusBarModule(
            IUnityContainer container, 
            IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        /// <summary>Initializes <c>this</c> instance.</summary>
        public void Initialize()
        {
            RegisterViewsAndServices();

            IStatusBarPresentationModel model = _container.Resolve<StatusBarPresentationModel>();
            var statusBarRegion = _regionManager.Regions["StatusBarRegion"];
            statusBarRegion.Add(model.View);
            statusBarRegion.Activate(model.View);
        }

        /// <summary>Registers the views and services.</summary>
        private void RegisterViewsAndServices()
        {
            _container.RegisterType<IStatusBarView, StatusBarView>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IStatusBarPresentationModel, StatusBarPresentationModel>(new ContainerControlledLifetimeManager());
        }
    }
}