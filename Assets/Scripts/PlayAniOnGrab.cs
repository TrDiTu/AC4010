using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ParticleOnGrab : MonoBehaviour
{
    public ParticleSystem particle;
    private UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grab;

    void Awake()
    {
        grab = GetComponent<UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable>();

        grab.selectEntered.AddListener(OnGrab);
        grab.selectExited.AddListener(OnRelease);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (particle != null)
            particle.Play();
    }

    void OnRelease(SelectExitEventArgs args)
    {
        if (particle != null)
            particle.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }
}
