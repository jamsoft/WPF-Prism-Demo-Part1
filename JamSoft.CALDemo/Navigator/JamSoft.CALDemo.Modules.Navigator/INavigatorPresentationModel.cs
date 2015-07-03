﻿#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.Navigator
// File Name    : INavigatorPresentationModel.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.Navigator
{
    using System.Collections.ObjectModel;

    using JamSoft.CALDemo.Modules.PageManager.Core;

    /// <summary>
    /// The navigator presentation model
    /// </summary>
    public interface INavigatorPresentationModel
    {
        /// <summary>Gets the view.</summary>
        /// <value>The view.</value>
        INavigatorView View { get; }

        /// <summary>Gets the collection of pages.</summary>
        /// <value>The pages.</value>
        ObservableCollection<IPage> Pages { get; }
    }
}