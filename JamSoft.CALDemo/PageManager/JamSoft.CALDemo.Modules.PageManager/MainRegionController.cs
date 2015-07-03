#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.PageManager
// File Name    : MainRegionController.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.PageManager
{
    using JamSoft.CALDemo.Modules.PageManager.Core;

    using Microsoft.Practices.Prism.PubSubEvents;
    using Microsoft.Practices.Prism.Regions;

    /// <summary>
    /// The main region controller
    /// </summary>
    public class MainRegionController : IMainRegionController
    {
        /// <summary>The _event aggregator</summary>
        private readonly IEventAggregator _eventAggregator;

        /// <summary>The _region manager</summary>
        private readonly IRegionManager _regionManager;

        /// <summary>The _current view</summary>
        private object _currentView;

        /// <summary>The _main region</summary>
        private IRegion _mainRegion;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainRegionController"/> class.
        /// </summary>
        /// <param name="regionManager">
        /// The region manager.
        /// </param>
        /// <param name="eventAggregator">
        /// The event aggregator.
        /// </param>
        public MainRegionController(
            IRegionManager regionManager, 
            IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;

            Initialize();
        }

        /// <summary>Initializes <c>this</c> instance.</summary>
        private void Initialize()
        {
            _eventAggregator.GetEvent<PageSelectedEvent>().Subscribe(PageSelected); //, ThreadOption.UIThread);
            _mainRegion = _regionManager.Regions["MainRegion"];
        }

        /// <summary>
        /// Pages the selected.
        /// </summary>
        /// <param name="page">
        /// The <c>page</c>.
        /// </param>
        private void PageSelected(IPage page)
        {
            if (page != null)
            {
                ShowPage(page);
            }
        }

        /// <summary>
        /// Shows the <c>page</c>.
        /// </summary>
        /// <param name="page">
        /// The <c>page</c>.
        /// </param>
        private void ShowPage(IPage page)
        {
            var newView = page.View;

            if (_currentView != null)
            {
                _mainRegion.Remove(_currentView);
            }

            if (newView != null)
            {
                _mainRegion.Add(newView);
                _mainRegion.Activate(newView);
            }

            _currentView = newView;
        }
    }
}