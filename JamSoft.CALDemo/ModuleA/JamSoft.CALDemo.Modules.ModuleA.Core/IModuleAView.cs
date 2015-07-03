#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.ModuleA.Core
// File Name    : IModuleAView.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.ModuleA.Core
{
    /// <summary>
    /// The module A view <c>interface</c>
    /// </summary>
    public interface IModuleAView
    {
        /// <summary>Sets the model.</summary>
        /// <value>The model.</value>
        IModuleAPresenterModel Model { set; }
    }
}