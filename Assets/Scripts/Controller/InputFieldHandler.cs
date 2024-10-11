using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputFieldHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private string sceneName;

    private Scene currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene();
    }

    public void ReadInputField()
    {
        GameManager.instance.playerName = inputField.text;
        transform.parent.gameObject.SetActive(false);
        if (currentScene.name != sceneName)
            SceneManager.LoadScene(sceneName);
    }
}
