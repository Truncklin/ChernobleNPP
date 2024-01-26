using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Teleport : MonoBehaviour
{
    [SerializeField] private GameObject pozTP;
    [SerializeField]private LoadingSlider loadingSlider;

    private GameObject player;
    private void OnTriggerStay(Collider other)
    {
        player = GameObject.FindWithTag("Player");
        if (other.CompareTag("Player"))
        {
            loadingSlider.SetActiveText();
            if (UnityEngine.Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Key E clicked");
                loadingSlider.SetSliderValue();
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

    public void Teleportation()
    {
        player.transform.position = pozTP.transform.position;
    }
}
