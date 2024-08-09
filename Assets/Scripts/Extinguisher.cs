using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    public float amountExtinguishedPerSecond;

    public GameObject fog;

    public void startExtinguish()
    {
        amountExtinguishedPerSecond = 1f;
    }

    public void stopExtinguish()
    {
        amountExtinguishedPerSecond = 0f;
    }

    void SetLayerRecursively(GameObject obj, int newLayer)
    {
        if (obj == null) return;

        obj.layer = newLayer;

        foreach (Transform child in obj.transform)
        {
            if (child != null)
            {
                SetLayerRecursively(child.gameObject, newLayer);
            }
        }
    }

    public void MakeWhiteFogInvisible()
    {
        int targetLayer = LayerMask.NameToLayer("Extinguisher");

        Debug.Log("making it invisible");
        Transform whiteFogTransform = fog.transform;

        if (whiteFogTransform != null)
        {
            Renderer whiteFogRenderer = whiteFogTransform.GetComponent<Renderer>();

            if (whiteFogRenderer != null)
            {
                SetLayerRecursively(fog, targetLayer);
            }
            else
            {
                Debug.LogWarning("Renderer component not found on WhiteFog.");
            }
        }
        else
        {
            Debug.LogWarning("Child named 'WhiteFog' not found.");
        }
    }

    public void MakeWhiteFogVisible()
    {
        int targetLayer = LayerMask.NameToLayer("Default");

        Debug.Log("making it invisible");
        Transform whiteFogTransform = fog.transform;

        if (whiteFogTransform != null)
        {
            Renderer whiteFogRenderer = whiteFogTransform.GetComponent<Renderer>();

            if (whiteFogRenderer != null)
            {
                SetLayerRecursively(fog, targetLayer);
            }
            else
            {
                Debug.LogWarning("Renderer component not found on WhiteFog.");
            }
        }
        else
        {
            Debug.LogWarning("Child named 'WhiteFog' not found.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(this.transform.position, this.transform.forward, out RaycastHit hit, 100f)
        && hit.collider.TryGetComponent(out Fire fire))
        {
            fire.TryExtinguish(amountExtinguishedPerSecond * Time.deltaTime);
        }
    }
}