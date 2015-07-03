#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.ModuleB.Core
// File Name    : IModuleBView.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.ModuleB.Core
{
    /// <summary>
    /// The module B view <see langword="interface"/>
    /// </summary>
    public interface IModuleBView
    {
        /// <summary>Sets the model.</summary>
        /// <value>The model.</value>
        IModuleBPresenterModel Model { set; }
    }
}