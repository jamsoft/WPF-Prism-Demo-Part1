#region File Header

// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Shell
// File Name    : Shell.xaml.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo
{
    using System.Windows;

    /// <summary>
    ///     Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window, IShellView
    {
        /// <summary>
        /// </summary>
        public Shell()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        public void ShowView()
        {
            Show();
        }
    }
}