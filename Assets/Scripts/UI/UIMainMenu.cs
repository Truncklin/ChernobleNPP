﻿using BaseClasses;
using Unit.Character;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIMainMenu : CustomBehaviour
	{
		[Tooltip("UI Manager.")][SerializeField]
		private UIManager uiManager;
		[Tooltip("Кнопка Новая игра")][SerializeField]
		private Button newGameButton;
		[Tooltip("Кнопка управление")][SerializeField]
		private Button instructionsButton;
		[Tooltip("Кнопка Выход")][SerializeField]
		private Button exitButton;
		[Tooltip("Player spawner.")][SerializeField]
		private PlayerSpawner playerSpawner;
		
		private void Start()
		{
			newGameButton.onClick.AddListener(NewGame);
			instructionsButton.onClick.AddListener(Instructions);
			exitButton.onClick.AddListener(Exit);
			
		}

		private void Instructions()
		{
			uiManager.OpenTab(UIManager.EuiTabs.InstructionsTab);
		}

		private void Exit()
		{
			Application.Quit();
		}

		private void NewGame()
		{
			playerSpawner.SpawnPlayer();
		}

		private void Continue()
		{
			playerSpawner.SpawnPlayer(false);
		}
	}
}