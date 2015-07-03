﻿#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.StatusBar
// File Name    : IStatusBarPresentationModel.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.StatusBar
{
    /// <summary>
    /// The Status bar presentation model
    /// </summary>
    public interface IStatusBarPresentationModel
    {
        /// <summary>Gets the view.</summary>
        /// <value>The view.</value>
        IStatusBarView View { get; }
    }
}