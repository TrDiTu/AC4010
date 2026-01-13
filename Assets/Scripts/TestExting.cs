using UnityEngine;

public class TestExting : MonoBehaviour
{
    [SerializeField] private float amountExtinguishedPerSecond = 0.1f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Update()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hitInfo, 100f) 
            && hitInfo.collider.TryGetComponent(out Fire fire))
        {
            print(hitInfo.collider.name);
            fire.TryExtinguish(amountExtinguishedPerSecond * Time.deltaTime);
        }

    }
}
