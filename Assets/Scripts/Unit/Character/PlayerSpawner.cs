using System.Collections.Generic;
using BaseClasses;
using Items;
using UnityEngine;

namespace Unit.Character
{
	public class PlayerSpawner : CustomBehaviour
	{
		[SerializeField] private GameObject character;
		[SerializeField] private GameObject virtualCamera;

		public void SpawnPlayer(bool isNewGame = true)
		{
			GameObject spawn = this.gameObject;
			SaveData saveData = isNewGame ? 
				new SaveData(spawn.transform.position, Quaternion.identity, 
					100, new Dictionary<Item, uint>()) : SavePrefs.Load();
			
			character.SetActive(true);
			virtualCamera.SetActive(false);
			GameStateEvents.GameStarted?.Invoke();
		}
	}
}