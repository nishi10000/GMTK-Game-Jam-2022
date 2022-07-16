using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.UI;
using UnityEngine.UI;

namespace TowerDefense.UI.HUD
{
	public class yakuzaDiffenseMainMenu : MainMenu
	{
        /// <summary>
        /// Reference to options menu
        /// </summary>
        public OptionsMenu optionsMenu;

		/// <summary>
		/// Reference to title menu
		/// </summary>
		public SimpleMainMenuPage titleMenu;

		/// <summary>
		/// Reference to level select menu
		/// </summary>
		public GameStartMenu gameStartMenu;

		/// <summary>
		/// Bring up the options menu
		/// </summary>
		public void ShowOptionsMenu()
		{
			ChangePage(optionsMenu);
		}

		/// <summary>
		/// Bring up the options menu
		/// </summary>
		public void ShowLevelSelectMenu()
		{
			gameStartMenu.ButtonClicked();
			
		}

		/// <summary>
		/// Returns to the title screen
		/// </summary>
		public void ShowTitleScreen()
		{
			Back(titleMenu);
		}

		/// <summary>
		/// Set initial page
		/// </summary>
		protected virtual void Awake()
		{
			ShowTitleScreen();
		}

		/// <summary>
		/// Escape key input
		/// </summary>
		protected virtual void Update()
		{
			if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
			{
				if ((SimpleMainMenuPage)m_CurrentPage == titleMenu)
				{
					Application.Quit();
				}
				else
				{
					Back();
				}
			}
		}
	}
}
	