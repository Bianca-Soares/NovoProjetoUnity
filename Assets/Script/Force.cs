using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Force : MonoBehaviour
{
    public Reiniciar telaReiniciar;

    // ref-> referência do componete para movimentar o heroi
    private Rigidbody refRigidbody;
    //as coordenadas para a movimentação são valores flutuantes
    //valor para coordenada de z
    private float eixoVertical;
    //valor para coordenada de x
    private float eixoHorizontal;
    private float velocidade2;

    [SerializeField] public float velocidade = .0f;
    private string mensagem;
    private string msg;
    private string textVelocidade;

    private int bonus = 0;
    private int danos = 0;
    Vector3 posiInicial;
    [SerializeField] public Text info;
  
    void Start()
    {
        refRigidbody = GetComponent<Rigidbody>();//a ref recebeu o rigidbody do heroi

        posiInicial = transform.position;//Editar para posição inicial
        mensagem = " Início";

        info.text = mensagem;
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void FixedUpdate()
    {
        
        //guardar informação das teclas
        eixoHorizontal = Input.GetAxis("Horizontal");
        eixoVertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocidade2 = eixoVertical++2;
        }

        //criar objeto Vector3 com os valores dos inputs
        Vector3 vetor = new Vector3(eixoHorizontal, 0.0f, eixoVertical);

        //adicionar força para o movimento
        refRigidbody.AddForce(vetor * velocidade);//mais velocidade 

        msg = "\n Danos: " + danos.ToString()+" % " + "\n Bonus: " + bonus.ToString();
       
         
        info.text = mensagem + msg;



    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Veloci"))
        {
            mensagem = " Ganhou Bônus";
           
            other.gameObject.SetActive(false);
            bonus = bonus + 10;
        }

    }


    private void OnCollisionEnter(Collision collision) {
        
        if (collision.gameObject.CompareTag("Star"))
        {
            mensagem = " Levou danos";
            

            danos = danos + 5;
            
        }

        if (collision.gameObject.CompareTag("ParedeLateral"))
        {
            mensagem = " Levou danos";

            danos = danos + 2;
        }

        if (collision.gameObject.CompareTag("ParedeFim"))
        {
            mensagem = " Levou danos";

            danos = danos + 10;
        }

        if (danos >= 100)
        {
            mensagem = " Fim de Jogo";
            msg = "\nDanos 100 % " + "\nBonus: " + bonus.ToString();
            info.text = mensagem + msg;
            this.gameObject.SetActive(false);

            telaReiniciar.Exibir(bonus);
        }
    }

    private void inicio()
    {

         
    }

}
