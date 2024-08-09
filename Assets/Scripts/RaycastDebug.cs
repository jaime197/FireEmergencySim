using UnityEngine;

public class RaycastDebug : MonoBehaviour
{
    public float rayDistance = 10f;
    public Color rayColor = Color.red;

    void Update()
    {
        // Define the origin and direction of the ray
        Vector3 origin = transform.position;
        Vector3 direction = transform.forward;

        // Perform the raycast
        RaycastHit hit;
        if (Physics.Raycast(origin, direction, out hit, rayDistance))
        {
            // Draw the ray in the Scene view
            Debug.DrawRay(origin, direction * hit.distance, rayColor);
            Debug.Log("Hit: " + hit.collider.name);

            // You can also do something with the hit object
            // For example, change its color
            Renderer renderer = hit.collider.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.color = Color.green;
            }
        }
        else
        {
            // Draw the ray to the maximum distance
            Debug.DrawRay(origin, direction * rayDistance, rayColor);
        }
    }
}
