#region File Header

// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.ModuleA
// File Name    : ModuleAView.xaml.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.ModuleA
{
    using System.Windows.Controls;

    using JamSoft.CALDemo.Modules.ModuleA.Core;

    /// <summary>
    ///     Interaction logic for ModuleAView.xaml
    /// </summary>
    public partial class ModuleAView : UserControl, IModuleAView
    {
        /// <summary>
        /// </summary>
        public ModuleAView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        public IModuleAPresenterModel Model
        {
            set
            {
                DataContext = value;
            }
        }
    }
}