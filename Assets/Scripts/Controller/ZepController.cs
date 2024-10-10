using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZepController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action�� ������ void�� ��ȯ�ؾ� �ƴϸ�
    public event Action<Vector2> OnLookEvent;


    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ?. ������ ���� ������ ����
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}
