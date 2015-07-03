﻿#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.ModuleA
// File Name    : ModuleAModule.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.ModuleA
{
    using JamSoft.CALDemo.Modules.ModuleA.Core;

    using Microsoft.Practices.Prism.Modularity;
    using Microsoft.Practices.Unity;

    /// <summary>
    /// The ModuleA class
    /// </summary>
    [Module(ModuleName = "ModuleA")]
    [ModuleDependency("PageManagerModule")]
    public class ModuleAModule : IModule
    {
        /// <summary>The _container</summary>
        private readonly IUnityContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleAModule"/> class.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        public ModuleAModule(IUnityContainer container)
        {
            _container = container;
        }

        /// <summary>Initializes instance.</summary>
        public void Initialize()
        {
            RegisterViewsAndServices();
            _container.Resolve<IModuleAPresenterModel>();
        }

        /// <summary>Registers the views and services.</summary>
        private void RegisterViewsAndServices()
        {
            _container.RegisterType<IModuleAView, ModuleAView>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IModuleAPresenterModel, ModuleAPresenterModel>(new ContainerControlledLifetimeManager());
        }
    }
}