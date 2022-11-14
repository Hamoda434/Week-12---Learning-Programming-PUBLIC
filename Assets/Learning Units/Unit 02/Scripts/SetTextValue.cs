using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetTextValue : MonoBehaviour
{
    TextMeshProUGUI textMeshProUGUI;
    [SerializeField] public bool isRotating;
    // Start is called before the first frame update
    void Start()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeText(bool isRotating)
    {
        if (isRotating)
        {
            textMeshProUGUI.text = "It's rotating!";
        }
        else { textMeshProUGUI.text = "It's not rotating."; }
    }
}
