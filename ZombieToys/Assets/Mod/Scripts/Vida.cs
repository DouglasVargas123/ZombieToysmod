using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    public PlayerHealth playerHealthBoy, playerHealthGirl;
    public bool Corazon = false;
    public GameObject DestruirCorazon;

    // Update is called once per frame
    void Update()
    {
            if (Corazon)
            {
                playerHealthBoy.TakeDamage(25 * (-1));
                playerHealthGirl.TakeDamage(25 * (-1));
                Destroy(DestruirCorazon);
            }     
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Boy" || other.name == "Girl")
        {
            Corazon = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Boy" || other.name == "Girl")
        {
            Corazon = false;
        }
    }
}
