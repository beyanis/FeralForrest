using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyTrigger : MonoBehaviour
{
    // Creation de variable
    [SerializeField] private GameObject[] targetDummies;

    private void OnTriggerEnter(Collider other)
    {
        // Condition pour dire que si un objet ayant le tag player
        if (other.gameObject.CompareTag("Player"))
        {
            //Touche la zone targetdummies
            foreach (GameObject dummies in targetDummies)
            {
                // Alors on active de nouveau l'animation des soldats
                dummies.GetComponent<targetdummy>().ActivateDummy();
            }
        }
    }
}
