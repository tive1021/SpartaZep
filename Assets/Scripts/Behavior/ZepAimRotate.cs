using System;
using UnityEngine;

public class ZepAimRotate : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private ZepController controller;


    private void Awake()
    {
        controller = GetComponent<ZepController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}