using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    [SerializeField] private Transform target;    // 따라갈 대상 (플레이어)
    [SerializeField] private Vector3 offset;      // 카메라와 대상 사이의 거리 (Z축은 카메라의 깊이를 위해 그대로 둡니다)
    [SerializeField] private float smoothSpeed = 0.125f; // 부드럽게 따라가기 위한 속도

    void FixedUpdate()
    {
        // 카메라가 따라갈 위치 (X, Y는 따라가고 Z는 카메라 깊이를 유지)
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;

        // 부드럽게 이동 (Lerp 사용)
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // 카메라 위치 설정
        transform.position = smoothedPosition;
    }
}
