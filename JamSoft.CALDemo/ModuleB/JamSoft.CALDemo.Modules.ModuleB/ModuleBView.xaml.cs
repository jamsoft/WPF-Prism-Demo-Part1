#region File Header

// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.ModuleB
// File Name    : ModuleBView.xaml.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.ModuleB
{
    using System.Windows.Controls;

    using JamSoft.CALDemo.Modules.ModuleB.Core;

    /// <summary>
    ///     Interaction logic for ModuleBView.xaml
    /// </summary>
    public partial class ModuleBView : UserControl, IModuleBView
    {
        /// <summary>
        /// </summary>
        public ModuleBView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        public IModuleBPresenterModel Model
        {
            set
            {
                DataContext = value;
            }
        }
    }
}