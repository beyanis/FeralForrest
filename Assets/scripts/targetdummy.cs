using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetdummy : MonoBehaviour
{
    //Creation de variable
    [SerializeField] private Animator dummyAnimator;
  
    //Lorsque le Event collision est present
    private void OnCollisionEnter(Collision other)
    {
        //Si l'objet en collision possede le tag weapon
        if (other.gameObject.CompareTag("weapon"))
        {
            //Lance l'animation de la mort du soldat
            dummyAnimator.SetTrigger("Death");
            
        }
    }

    public void ActivateDummy()
    {
        //Active l'animation de nouveau et attend
        dummyAnimator.SetTrigger("Activate");
    }
}
