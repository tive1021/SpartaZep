using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // ������ �̵��� �Ͼ ������Ʈ

    private ZepController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;
    private Vector2 knockback = Vector2.zero;
    private float knockbackDuration = 0.0f;

    [SerializeField]private float speed = 1.0f;

    private void Awake()
    {
        // �ַ� �� ������Ʈ �ȿ��� ������ ��

        // controller�� TopDownMovement�� ���� ���ӿ�����Ʈ �ȿ� �ִٶ�� ����
        controller = GetComponent<ZepController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        // FixedUpdate�� ���� ������Ʈ ����
        // rigidbody�� ���� �ٲٴϱ� FixedUpdate
        ApplyMovement(movementDirection);

    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;

        movementRigidbody.velocity = direction;
    }

}