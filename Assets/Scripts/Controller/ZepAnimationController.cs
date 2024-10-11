using System;
using UnityEditor.Animations;
using UnityEngine;

public class ZepAnimationController : AnimationController
{
    private static readonly int isWalking = Animator.StringToHash("IsWalking");

    private readonly float magnituteThreshold = 0.5f;

    [SerializeField] private AnimatorController penguin;
    [SerializeField] private AnimatorController knight;


    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
        
    }

    private void Update()
    {
        ChangeCharacter();
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }

    private void ChangeCharacter()
    {
        if (GameManager.instance.sprite == GameManager.playerSprite.penguin)
        {
            animator.runtimeAnimatorController = penguin;
        }
        else if (GameManager.instance.sprite == GameManager.playerSprite.knight)
        {
            animator.runtimeAnimatorController = knight;
        }
    }
}
