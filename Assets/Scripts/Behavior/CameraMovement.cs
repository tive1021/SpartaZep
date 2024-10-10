using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    [SerializeField] private Transform target;    // ���� ��� (�÷��̾�)
    [SerializeField] private Vector3 offset;      // ī�޶�� ��� ������ �Ÿ� (Z���� ī�޶��� ���̸� ���� �״�� �Ӵϴ�)
    [SerializeField] private float smoothSpeed = 0.125f; // �ε巴�� ���󰡱� ���� �ӵ�

    void FixedUpdate()
    {
        // ī�޶� ���� ��ġ (X, Y�� ���󰡰� Z�� ī�޶� ���̸� ����)
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;

        // �ε巴�� �̵� (Lerp ���)
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // ī�޶� ��ġ ����
        transform.position = smoothedPosition;
    }
}
