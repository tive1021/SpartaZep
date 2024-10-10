using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerInputController : ZepController
{
    private Camera _camera;

    protected void Awake()
    {
        _camera = Camera.main; // mainCamera �±� �پ��ִ� ī�޶� �����´�
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
        // ���� �����̴� ó���� ���⼭ �ϴ°� �ƴ϶� PlayerMovement���� ��
    }

    public void OnLook(InputValue value)
    {
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        // Vector ���� �Ǽ��� ��ȯ
        {
            CallLookEvent(newAim);
        }

    }
}
