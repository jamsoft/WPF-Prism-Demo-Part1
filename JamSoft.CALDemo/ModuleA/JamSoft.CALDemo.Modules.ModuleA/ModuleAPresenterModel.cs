#region File Header
// ====================================================================
// Copyright (c) 2015, James Alexander Green (JamSoft)
// Some Rights Reserved :)
// ====================================================================
// File Details
// Solution Name: JamSoft.CALDemo
// Project Name : JamSoft.CALDemo.Modules.ModuleA
// File Name    : ModuleAPresenterModel.cs
// Created     : 03/07/2015 12:54
// ====================================================================
#endregion

namespace JamSoft.CALDemo.Modules.ModuleA
{
    using JamSoft.CALDemo.Modules.ModuleA.Core;
    using JamSoft.CALDemo.Modules.PageManager.Core;

    /// <summary>
    /// The Module A Presenter
    /// </summary>
    public class ModuleAPresenterModel : IModuleAPresenterModel, IPage
    {
        /// <summary>The _page manager</summary>
        private readonly IPageManager _pageManager;

        /// <summary>The _view</summary>
        private readonly IModuleAView _view;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleAPresenterModel"/> class.
        /// </summary>
        /// <param name="view">
        /// The view.
        /// </param>
        /// <param name="pageManager">
        /// The page manager.
        /// </param>
        public ModuleAPresenterModel(
            IModuleAView view, 
            IPageManager pageManager)
        {
            _view = view;
            _view.Model = this;

            _pageManager = pageManager;
            _pageManager.Pages.Add(this);
        }

        /// <summary>Gets the identifier.</summary>
        /// <value>The identifier.</value>
        public string ID
        {
            get
            {
                return "Module A";
            }
        }

        /// <summary>Gets the position.</summary>
        /// <value>The position.</value>
        public float Position
        {
            get
            {
                return 10F;
            }
        }

        /// <summary>Gets the view.</summary>
        /// <value>The view.</value>
        public object View
        {
            get
            {
                return _view;
            }
        }
    }
}