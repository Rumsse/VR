using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class gnatscript : MonoBehaviour
{


    private void Start()
    {
        XRBaseInteractable xrBaseInteractable = GetComponent<XRBaseInteractable>();
        xrBaseInteractable.activated.AddListener(TriggerHapticFeedback);

    }

    private void TriggerHapticFeedback(ActivateEventArgs arg0)
    {
        if (arg0.interactorObject is XRBaseInteractor controllerInteractor)
        {
            TriggerHaptic(controllerInteractor);
        }

    }
    private void TriggerHaptic(XRBaseInteractor interactor)
    {
        interactor.GetComponentInParent<HapticImpulsePlayer>().SendHapticImpulse(amplitude: 1, duration: 70); 
    }

}
