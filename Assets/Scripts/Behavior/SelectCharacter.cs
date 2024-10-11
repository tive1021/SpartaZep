using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour
{
    [SerializeField] private Image selectImage;
    private Image characterSelect;
    [SerializeField] private Button penguin;
    [SerializeField] private Button knight;
    [SerializeField] private Sprite penguinImage;
    [SerializeField] private Sprite knightImage;

    // Start is called before the first frame update
    private void Start()
    {
        characterSelect = GetComponent<Image>();
    }

    public void OnclickPenguin()
    {
        Debug.Log(2);
        GameManager.instance.sprite = GameManager.playerSprite.penguin;
        selectImage.sprite = penguinImage;
        characterSelect.gameObject.SetActive(false);
        selectImage.gameObject.SetActive(true);
    }

    public void OnClickKnight()
    {
        Debug.Log(3);
        GameManager.instance.sprite = GameManager.playerSprite.knight;
        selectImage.sprite = knightImage;
        characterSelect.gameObject.SetActive(false);
        selectImage.gameObject.SetActive(true);
    }

}
