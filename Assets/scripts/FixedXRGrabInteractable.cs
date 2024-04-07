using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FixedXRGrabInteractable : XRGrabInteractable
{
    [SerializeField] private Transform leftHandAttachTransform;
    [SerializeField] private Transform rightHandAttachTransform;
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (args.interactorObject.transform.CompareTag("lefthand"))
        {
            attachTransform= leftHandAttachTransform;
        }
        if (args.interactorObject.transform.CompareTag("righthand"))
        {
            attachTransform = rightHandAttachTransform;
        }
        base.OnSelectEntered(args);


    }







}
