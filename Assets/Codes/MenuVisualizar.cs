using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class MenuVisualizar : MonoBehaviour
{
    static public int num_consultas;


    public void activacionCanvas(GameObject menuAux)
    {
        menuAux.SetActive(true);
    }

    public void desactivacionCanvas(GameObject menuAux)
    {
        menuAux.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
