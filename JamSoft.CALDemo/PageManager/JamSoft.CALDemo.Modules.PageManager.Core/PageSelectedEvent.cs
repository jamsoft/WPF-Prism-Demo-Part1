﻿#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.PageManager.Core
// File Name    : PageSelectedEvent.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.PageManager.Core
{
    using Microsoft.Practices.Prism.PubSubEvents;

    /// <summary>
    /// The Page Selected Event
    /// </summary>
    public class PageSelectedEvent : PubSubEvent<IPage>
    {
    }
}