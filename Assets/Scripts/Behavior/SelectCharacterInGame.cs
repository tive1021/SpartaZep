using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterInGame : MonoBehaviour
{
    [SerializeField] private Button penguin;
    [SerializeField] private Button knight;

    // Start is called before the first frame update
    private void Start()
    {
    }

    public void OnclickPenguin()
    {
        GameManager.instance.sprite = GameManager.playerSprite.penguin;
    }

    public void OnClickKnight()
    {
        GameManager.instance.sprite = GameManager.playerSprite.knight;
    }
}
