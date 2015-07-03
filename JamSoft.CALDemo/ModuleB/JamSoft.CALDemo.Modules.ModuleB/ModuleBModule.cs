﻿#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.ModuleB
// File Name    : ModuleBModule.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.ModuleB
{
    using JamSoft.CALDemo.Modules.ModuleB.Core;

    using Microsoft.Practices.Prism.Modularity;
    using Microsoft.Practices.Unity;

    /// <summary>
    /// The module B module initializer
    /// </summary>
    [Module(ModuleName = "ModuleB")]
    [ModuleDependency("PageManagerModule")]
    public class ModuleBModule : IModule
    {
        /// <summary>The _container</summary>
        private readonly IUnityContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleBModule"/> class.
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        public ModuleBModule(IUnityContainer container)
        {
            _container = container;
        }

        /// <summary>Initializes this instance.</summary>
        public void Initialize()
        {
            RegisterViewsAndServices();
            _container.Resolve<IModuleBPresenterModel>();
        }

        /// <summary>Registers the views and services.</summary>
        private void RegisterViewsAndServices()
        {
            _container.RegisterType<IModuleBView, ModuleBView>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IModuleBPresenterModel, ModuleBPresenterModel>(new ContainerControlledLifetimeManager());
        }
    }
}