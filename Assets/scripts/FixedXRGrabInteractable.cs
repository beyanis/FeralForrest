using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FixedXRGrabInteractable : XRGrabInteractable
{
    // Creation des variables
    [SerializeField] private Transform leftHandAttachTransform;
    [SerializeField] private Transform rightHandAttachTransform;
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        //Si le joueur tient l'objet avec sa main gauche
        if (args.interactorObject.transform.CompareTag("lefthand"))
        {
            //Utilise les coordonnées de la main gauche au moment du grip
            attachTransform= leftHandAttachTransform;
        }
        //Si le joueur tient l'objet avec sa main droite
        if (args.interactorObject.transform.CompareTag("righthand"))
        {
            //Utilise les coordonnées de la main droite au moment du grip
            attachTransform = rightHandAttachTransform;
        }
        base.OnSelectEntered(args);


    }







}
