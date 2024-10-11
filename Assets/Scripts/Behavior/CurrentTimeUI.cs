using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CurrentTimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentTimeText;

    // Update is called once per frame
    void Update()
    {
        currentTimeText.text = DateTime.Now.ToString(("HH : mm"));
    }
}
