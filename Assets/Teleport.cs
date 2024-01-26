using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject pozTP;
    [SerializeField]private LoadingSlider loadingSlider;

    private GameObject _player;
    private void OnTriggerStay(Collider other)
    {
        _player = GameObject.FindWithTag("Player");
        if (other.CompareTag("Player"))
        {
            loadingSlider.SetActiveText();
            if (UnityEngine.Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Key E clicked");
                loadingSlider.SetSliderValue(pozTP.transform.position);
                
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            loadingSlider.DisableText();
        }
    }

    public void Teleportation(Vector3 positionTeleport)
    {
        NavMeshAgent navMeshAgent = _player.GetComponent<NavMeshAgent>();
        navMeshAgent.enabled = false;
        _player.transform.position = positionTeleport;
        navMeshAgent.enabled = true;
    }
}
