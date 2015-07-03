﻿#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.PageManager.Core
// File Name    : IPageManager.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.PageManager.Core
{
    using System.Collections.ObjectModel;

    /// <summary>
    /// The IPageManager <see langword="interface"/>
    /// </summary>
    public interface IPageManager
    {
        /// <summary>Gets the pages.</summary>
        /// <value>The pages.</value>
        ObservableCollection<IPage> Pages { get; }

        /// <summary>Gets the current page.</summary>
        /// <value>The current page.</value>
        IPage CurrentPage { get; }

        /// <summary>Gets the page.</summary>
        /// <param name="pageId">The page identifier.</param>
        /// <returns></returns>
        IPage GetPage(string pageId);
    }
}