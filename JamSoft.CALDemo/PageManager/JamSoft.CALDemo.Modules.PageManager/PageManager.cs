#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.PageManager
// File Name    : PageManager.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.PageManager
{
    using System.Collections.ObjectModel;
    using System.Linq;

    using JamSoft.CALDemo.Modules.PageManager.Core;

    using Microsoft.Practices.Prism.PubSubEvents;

    /// <summary>The page manager</summary>
    public class PageManager : IPageManager
    {
        /// <summary>The _event aggregator</summary>
        private readonly IEventAggregator _eventAggregator;

        /// <summary>The _pages</summary>
        private readonly ObservableCollection<IPage> _pages = new ObservableCollection<IPage>();

        /// <summary>The _current page</summary>
        private IPage _currentPage;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageManager"/> class.
        /// </summary>
        /// <param name="eventAggregator">
        /// The event aggregator.
        /// </param>
        public PageManager(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<PageRequestEvent>().Subscribe(OnPageSelected); //, ThreadOption.UIThread);
        }

        /// <summary>
        /// Gets the collection of pages
        /// </summary>
        public ObservableCollection<IPage> Pages
        {
            get
            {
                SortPages();
                return _pages;
            }
        }

        /// <summary>
        /// Gets the currently active page
        /// </summary>
        public IPage CurrentPage
        {
            get
            {
                return _currentPage;
            }
        }

        /// <summary>
        /// The GetPage method to return the requested page
        /// </summary>
        /// <param name="pageId">The page ID to return</param>
        /// <returns>The request IPage</returns>
        public IPage GetPage(string pageId)
        {
            IPage selPage = null;
            for (var i = 0; i < Pages.Count(); i++)
            {
                if (Pages[i].ID == pageId)
                {
                    selPage = Pages[i];
                }
            }

            return selPage;
        }

        /// <summary>
        /// The OnPageSelected Event
        /// </summary>
        /// <param name="page">The <c>page</c> to show</param>
        private void OnPageSelected(IPage page)
        {
            _currentPage = page;
            _eventAggregator.GetEvent<PageSelectedEvent>().Publish(page);
        }

        /// <summary>Sorts the pages.</summary>
        private void SortPages()
        {
            var p = _pages.ToList();
            p.Sort(new PagePositionComparer());
            _pages.Clear();
            foreach (var page in p)
            {
                _pages.Add(page);
            }
        }
    }
}