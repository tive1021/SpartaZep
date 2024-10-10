using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputFieldHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private string scene;

    public void ReadInputField()
    {
        GameManager.instance.playerName = inputField.text;
        SceneManager.LoadScene(scene);
    }
}
