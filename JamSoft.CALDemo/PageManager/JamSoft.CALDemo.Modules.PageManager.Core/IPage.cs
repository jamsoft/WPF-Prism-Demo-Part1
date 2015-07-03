#region File Header

// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.PageManager.Core
// File Name    : IPage.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.PageManager.Core
{
    /// <summary>
    /// The IPage <see langword="interface"/>
    /// </summary>
    public interface IPage
    {
        /// <summary>Gets the identifier.</summary>
        /// <value>The identifier.</value>
        string ID { get; }

        /// <summary>Gets the position.</summary>
        /// <value>The position.</value>
        float Position { get; }

        /// <summary>Gets the view.</summary>
        /// <value>The view.</value>
        object View { get; }
    }
}