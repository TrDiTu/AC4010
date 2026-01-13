using UnityEngine;

public class TestFire : MonoBehaviour
{
    [SerializeField, Range(0f,1f)] private float currentIntensity = 1.0f;
    private float startIntensity = 5.0f;
    [SerializeField] private ParticleSystem firePS = null;

    private void Start()
    {
        startIntensity = firePS.emission.rateOverTime.constant;
    }

    private void Update()
    {
        ChangeIntensity(); 
    }
    private void ChangeIntensity()
    {
        var emission = firePS.emission.rateOverTime;
        emission.constant = currentIntensity * startIntensity;
    }
}
