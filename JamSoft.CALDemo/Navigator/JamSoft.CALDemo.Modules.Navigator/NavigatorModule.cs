#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.Navigator
// File Name    : NavigatorModule.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.Navigator
{
    using Microsoft.Practices.Prism.Modularity;
    using Microsoft.Practices.Prism.Regions;
    using Microsoft.Practices.Unity;

    /// <summary>
    /// The navigator module initializer
    /// </summary>
    [Module(ModuleName = "NavigatorModule")]
    [ModuleDependency("PageManagerModule")]
    public class NavigatorModule : IModule
    {
        /// <summary>The _container</summary>
        private readonly IUnityContainer _container;

        /// <summary>The _region manager</summary>
        private readonly IRegionManager _regionManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="NavigatorModule"/> class.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        /// <param name="regionManager">
        /// The region manager.
        /// </param>
        public NavigatorModule(
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

            INavigatorPresentationModel model = _container.Resolve<NavigatorPresentationModel>();
            var navRegion = _regionManager.Regions["NavigatorRegion"];

            navRegion.Add(model.View);
            navRegion.Activate(model.View);
        }

        /// <summary>Registers the views and services.</summary>
        protected void RegisterViewsAndServices()
        {
            _container.RegisterType<INavigatorView, NavigatorView>();
        }
    }
}