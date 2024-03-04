using System;
using BaseClasses;
using Input;
using Inventory;
using StarterAssets;
using UnityEngine;
using UnityEngine.UI;
using CharacterController = Unit.Character.CharacterController;

namespace UI
{
	public class UIPauseMenu : CustomBehaviour
	{
		[Tooltip("Персонаж")][SerializeField]
		private GameObject player;
		[Tooltip("floor")][SerializeField]
		private Button firstFloor;
		[Tooltip("floor")][SerializeField]
		private Button secondFloor;
		[Tooltip("floor")][SerializeField]
		private Button vent;

		[SerializeField] private Elevator Elevator;


		void Start()
		{

		}

		protected override void OnEnable()
		{
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;

			
			InputManager.PlayerActions.Disable();
			GameStateEvents.GamePaused?.Invoke();
		}

		protected override void OnDisable()
		{
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
			
			
			InputManager.PlayerActions.Enable();
			GameStateEvents.GameResumed?.Invoke();
		}
		

	}
}