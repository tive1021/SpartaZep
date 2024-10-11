using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectController : MonoBehaviour
{
    private Button SelectButton;
    [SerializeField] private Image characterSelect;

    private void Start()
    {
        SelectButton = GetComponent<Button>();
    }

    public void Select()
    {
        characterSelect.gameObject.SetActive(true);
        SelectButton.gameObject.SetActive(false);
    }

}
