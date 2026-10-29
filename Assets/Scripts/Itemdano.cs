using UnityEngine;

public class ItemDano : MonoBehaviour
{

    public int dano = 20;

    public bool someAoTocar = true;


    private void OnTriggerEnter(Collider outro)

    {

        Debug.Log("Encostou no item de dano: " + outro.name);


        Vida vida = outro.GetComponent<Vida>();


        if (vida != null)

        {

            vida.TomarDano(dano);


            if (someAoTocar)

            {

                Destroy(gameObject);

            }

        }

        else
        {

            Debug.LogWarning(outro.name + " não tem o script Vida.");

        }

    }

}
