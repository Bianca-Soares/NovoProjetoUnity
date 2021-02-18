using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inicio : MonoBehaviour
{
    public string cenaInicial;
    public float tempofixoSeg = 5;
    public enum TipoCarregamento { Carregamento, TempoFixo}; //barra de seleção

    public TipoCarregamento TipoDeCarregamento;

    public Text textContagem;
    private int contagem;
    private string textoOriginal;
    private float ContTemp = 0;
     
    private float deltaTime = 0;


    void Start()
    {
        
        //timeScore.text = time.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ContTemp += 1 * Time.deltaTime;
        if (ContTemp >= 1)
        {
            deltaTime -= 1;
            ContTemp = 0;
        }

        if (deltaTime <= 0)
        {
            //tempo acaba 
        }
    }
}
