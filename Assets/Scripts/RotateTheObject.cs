using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTheObject : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAmount);
    }
}
