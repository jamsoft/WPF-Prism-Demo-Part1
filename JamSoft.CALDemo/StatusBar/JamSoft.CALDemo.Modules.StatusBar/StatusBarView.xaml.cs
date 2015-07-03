#region File Header

// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.StatusBar
// File Name    : StatusBarView.xaml.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.StatusBar
{
    using System.Windows.Controls;

    /// <summary>
    ///     Interaction logic for ssStatusBar.xaml
    /// </summary>
    public sealed partial class StatusBarView : UserControl, IStatusBarView
    {
        /// <summary>
        /// </summary>
        public StatusBarView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        public IStatusBarPresentationModel Model
        {
            set
            {
                DataContext = value;
            }
        }
    }
}