using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    // This boolean value needs to stay private, but that 
    // doesn't mean no outside classes can ever change it...

    [SerializeField] private bool isRotating;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRotating) //changed to the public method
        {
            transform.Rotate(0, .1f, 0);
        }
        
    }

    public bool IsRotating //added public method
    {
        get {return isRotating;}
        set {isRotating = value;}
    }

}
