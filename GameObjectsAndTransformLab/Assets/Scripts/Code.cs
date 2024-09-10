using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    public GameObject targetObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Access the Transform component of the target object
        Transform targetTransform = targetObject.transform;

        // Modify position
        targetTransform.position = new Vector3(1f, 2f, 3f); // Set a new position

        // Modify rotation
        targetTransform.rotation = Quaternion.Euler(45f, 30f, 0f); // Set a new rotation

        // Modify scale
        targetTransform.localScale = new Vector3(2f, 1f, 0.5f); // Set a new scale
    }
}
