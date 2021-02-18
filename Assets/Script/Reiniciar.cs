using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//

public class Reiniciar : MonoBehaviour
{

    public Text textPontos;
    //LoadScene Carrega a cena por seu índice ou seu nome
    public void Exibir(int score)
    {
        gameObject.SetActive(true);
        textPontos.text = "Bônus " +score.ToString();
    }

    public void BtnReinicia()// função reiniciar jogo
    {
        SceneManager.LoadScene("Jogo");
    }

}
