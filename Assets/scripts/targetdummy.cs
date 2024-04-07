using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetdummy : MonoBehaviour
{
    [SerializeField] private Animator dummyAnimator;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("weapon"))
        {
            dummyAnimator.SetTrigger("Death");
        }
    }

    public void ActivateDummy()
    {
        dummyAnimator.SetTrigger("Activate");
    }
}
