#region File Header

// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.Navigator
// File Name    : NavigatorView.xaml.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.Navigator
{
    using System;
    using System.Windows.Controls;

    using JamSoft.CALDemo.Modules.PageManager.Core;

    /// <summary>
    ///     Interaction logic for NavigatorView.xaml
    /// </summary>
    public partial class NavigatorView : UserControl, INavigatorView
    {
        /// <summary>
        /// </summary>
        private INavigatorPresentationModel _model;

        /// <summary>
        /// </summary>
        private IPage _selectedPage;

        /// <summary>
        /// </summary>
        public NavigatorView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// </summary>
        public event EventHandler<PageEventArgs> ItemChangeRequest;

        /// <summary>
        /// </summary>
        public INavigatorPresentationModel Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
                DataContext = value;
            }
        }

        /// <summary>
        /// </summary>
        public IPage SelectedItem
        {
            get
            {
                return TheListView.SelectedItem as IPage;
            }

            set
            {
                _selectedPage = value;
                SetListViewItemWithoutEvent(_selectedPage);
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="page">
        /// </param>
        private void OnItemChangeRequest(IPage page)
        {
            if (ItemChangeRequest != null)
            {
                ItemChangeRequest(this, new PageEventArgs(page));
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="page">
        /// </param>
        private void SetListViewItemWithoutEvent(IPage page)
        {
            TheListView.SelectedItem = page;
        }

        /// <summary>
        /// </summary>
        /// <param name="sender">
        /// </param>
        /// <param name="e">
        /// </param>
        private void theListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listBoxSelectedPage = TheListView.SelectedItem as IPage;

            if (listBoxSelectedPage != _selectedPage)
            {
                SetListViewItemWithoutEvent(_selectedPage);
            }

            OnItemChangeRequest(listBoxSelectedPage);
        }
    }
}