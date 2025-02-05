using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class XRInteractorTag : XRSocketInteractor
{
    public string Tag;

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return base.CanSelect (interactable) && interactable.transform.CompareTag (tag);
    }

}
