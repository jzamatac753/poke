using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class DataBaseInfo : MonoBehaviour
{

    public GameObject text0;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;

    public void infoBaseData()
    {
        string[] datosExtraidos;

        var valor0 = text0.GetComponent<Text>();
        valor0.text = "01 - Pikachu";

        var valor1 = text1.GetComponent<Text>();
        valor1.text = "02 - Charmander";

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
