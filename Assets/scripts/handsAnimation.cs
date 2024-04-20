using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class handsAnimation : MonoBehaviour
{
    //Creation des variables
    [SerializeField] private InputActionReference gripReference;
    [SerializeField] private InputActionReference triggerReference;
    [SerializeField] private Animator handAnimator;




    void Update()
    {
        //Allouer et lire la valeur de la touche grip dans une variable
       float gripValue = gripReference.action.ReadValue<float>();

        //choisir l'animation de l'action grip
        handAnimator.SetFloat("Grip", gripValue);

        //Allouer et lire la valeur de la touche trigger dans une variable
        float triggerValue = triggerReference.action.ReadValue<float>();

        //choisir l'animation de l'action trigger
        handAnimator.SetFloat("Trigger", triggerValue);
    }
}
