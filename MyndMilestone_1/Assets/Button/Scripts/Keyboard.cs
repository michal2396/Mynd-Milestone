using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Keyboard : MonoBehaviour
{
    // Start is called before the first frame update
    
    public TMP_InputField inputField;
    public GameObject normalButtons;
    public GameObject capsButtons;
    private bool caps; 
    // Start is called before the first frame update
    void Start()
    {
        caps = false;
    }

    public void InsertChar(string c)
    {
        inputField.text += c;
    }

    public void DeleteChar()
    {
        if (inputField.text.Length > 0)
        {
            inputField.text = inputField.text.Substring(0, inputField.text.Length - 1);
        }
    }

    public void EnterSpace()
    {
        inputField.text += " ";
    }

    public void CapsPressed()
    {
        if (!caps) //caps == true
        {
            normalButtons.SetActive(false);
            capsButtons.SetActive(true);
            caps = true;
        }
        else 
        {
            capsButtons.SetActive(false);
            normalButtons.SetActive(true);
            caps = false;
        }
    }
}
