using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmmisionChange : MonoBehaviour
{
    [SerializeField] private int time;
    [SerializeField] private Material material;
    [SerializeField] private Renderer objectre;
    private Material mat;
    // Start is called before the first frame update
    void Start()
    {
        Material mat = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        enumerator();
        mat.;
    }
    IEnumerator enumerator()
    {
        yield return new WaitForSeconds(time);
    }
}
