using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSlider : MonoBehaviour
{
    private Slider _slider;

    [SerializeField] private GameObject uiSlider;
    [SerializeField] private GameObject text;

    [SerializeField] private Teleport _teleport;

    private void Start()
    {
        _slider = uiSlider.GetComponent<Slider>();
    }

    public void SetActiveText()
    {
        text.SetActive(true);
    }

    public void SceneLoader(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void DisableText()
    {
        text.SetActive(false);
    }
}