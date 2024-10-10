using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // 실제로 이동이 일어날 컴포넌트

    private ZepController controller;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    [SerializeField]private float speed = 1.0f;

    private void Awake()
    {
        // 주로 내 컴포넌트 안에서 끝나는 거
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
        // FixedUpdate는 물리 업데이트 관련
        // rigidbody의 값을 바꾸니까 FixedUpdate
        ApplyMovement(movementDirection);

    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * speed;

        movementRigidbody.velocity = direction;
    }

}