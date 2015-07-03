﻿#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.Navigator
// File Name    : INavigatorView.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.Navigator
{
    using System;

    using JamSoft.CALDemo.Modules.PageManager.Core;

    /// <summary>
    /// The navigator view <see langword="interface"/>
    /// </summary>
    public interface INavigatorView
    {
        /// <summary>Gets or sets the selected item.</summary>
        /// <value>The selected item.</value>
        IPage SelectedItem { get; set; }

        /// <summary>Sets the model.</summary>
        /// <value>The model.</value>
        INavigatorPresentationModel Model { set; }

        /// <summary>Occurs when [item change request].</summary>
        event EventHandler<PageEventArgs> ItemChangeRequest;
    }
}