using UnityEngine;
using UnityEngine.SceneManagement;

public class Porta : MonoBehaviour
{
    public bool correta = false;               
    public bool aberta = false;                

    [Header("Movimento ao abrir")]
    public Vector3 direcao = Vector3.right;    
    public float distanciaAbrir = 1.5f;       
    public float velocidade = 2f;

    [Header("Proxima fase")]
    public string proximaFase = "Fase2";
    public float TempoAntesDaTraca = 2f;
    Vector3 posicaoAberta;

    void Start()
    {
       
        posicaoAberta = transform.position + direcao.normalized * distanciaAbrir;
    }

 
    public string Interagir()
    {
        if (correta)
        {
            aberta = true;
            Invoke(nameof(IrProximaFase), TempoAntesDaTraca);
            return "Você acertou a porta!";
        }
        return "Trancada! Tente outra porta.";
    }

    void Update()
    {
      
        if (aberta)
        {
            transform.position = Vector3.MoveTowards(
                transform.position, posicaoAberta, velocidade * Time.deltaTime);
        }
    }
    void IrProximaFase()
    {
        SceneManager.LoadScene(proximaFase);
    }
}
