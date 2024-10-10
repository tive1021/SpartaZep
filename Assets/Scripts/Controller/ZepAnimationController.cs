using System;
using UnityEngine;

public class ZepAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("IsWalking");

    private readonly float magnituteThreshold = 0.5f;


    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }

}
