using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;

    public void ReadInputField()
    {
        string inputText = inputField.text;
        Debug.Log(inputText);
    }
}
