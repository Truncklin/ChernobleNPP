    using System.Collections;
    using StarterAssets;
    using Unit.Character;
    using UnityEngine;
    using UnityEngine.AI;
    using UnityEngine.SceneManagement;
    using CharacterController = UnityEngine.CharacterController;


    public class Elevator : MonoBehaviour
    {
        [SerializeField] private GameObject UI;
        private Vector3 positionTeleport = new (554,61,635);
        private Collider _elevatorCollider;

        [SerializeField]  private GameObject _player;
        [Tooltip("Player spawner.")][SerializeField]
        private PlayerSpawner playerSpawner;
        

        private void OnTriggerStay(Collider other)
        {
            _player = GameObject.FindWithTag("Player");
            if (other.CompareTag("Player")) {_player.GetComponent<FirstPersonController>().enabled = false;
                UI.SetActive(true);
            }
            
        }

        
        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
                UI.SetActive(false);
            _player.GetComponent<CharacterController>().enabled = false;
        }

        public void Load1()
        {
            if(SceneManager.GetActiveScene().buildIndex != 1){ SceneManager.LoadScene(1); StartCoroutine(WaitScene(1)); }
        else {}
            Debug.Log("1");
        }
        public void Load2()
        {
            if(SceneManager.GetActiveScene().buildIndex != 2){ SceneManager.LoadScene(2); StartCoroutine(WaitScene(2));}
            else {}
            Debug.Log("2");
        }

        public void Vent()
        {
            if (SceneManager.GetActiveScene().buildIndex != 0)
            {
                StartCoroutine(Teleportation()); 
            }
            Debug.Log("vent");
        }

        private IEnumerator Teleportation()
        {
            SceneManager.LoadScene(0);
            yield return new WaitUntil(() => SceneManager.GetSceneByBuildIndex(0).isLoaded);
        }
        private IEnumerator WaitScene(int i)
        {
            while(SceneManager.GetSceneByBuildIndex(i).isLoaded){}
            yield return null;
        }
        
    }
