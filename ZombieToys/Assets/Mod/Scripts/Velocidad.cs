using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocidad : MonoBehaviour
{
    public PlayerMovement playerMovementBoy, playerMovementGirl;
    bool Rayo = false;
    public GameObject DestruirRayo;

    public float contador = 1f;



    // Update is called once per frame
    void Update()
    {
        if (Rayo)
        {
            contador = contador + 1 * Time.deltaTime;
            playerMovementBoy.speed = 15f;
            playerMovementGirl.speed = 15f;


        }
        if (contador >= 6)
        {
            playerMovementBoy.speed = 6f;
            playerMovementGirl.speed = 6f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Rayo")
        {
            Rayo = true;
            Destroy(DestruirRayo);
        }
    }
}
