using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleGameObject : MonoBehaviour
{
    [SerializeField] private GameObject m_gameObject;

    public void ButtonClicked()
    {
        if (m_gameObject.activeSelf)
        {
            m_gameObject.SetActive(false);
        }
        else
        {
            m_gameObject.SetActive(true);

        }
    }
}
