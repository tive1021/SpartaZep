using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNameHandler : MonoBehaviour
{
    [SerializeField] private TMP_Text playerNameText;

    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text = GameManager.instance.playerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
