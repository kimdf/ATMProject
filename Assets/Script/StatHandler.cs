using UnityEngine;

public class StatHandler : MonoBehaviour
{
    [Range(1, 100)][SerializeField] private int health = 10;
    public int Health
    {
        get => health;
        set => health = Mathf.Clamp(value, 0, 100);
    }

    [Range(1f, 20f)][SerializeField] private float speed = 3;
    public float Speed
    {
        get => speed;
        set => speed = Mathf.Clamp(value, 0, 20);
    }
    [Header("Play Area")]
    [Tooltip("플레이어가 벗어나지 못하게 할 BoxCollider(또는 다른 Collider)를 할당하세요. Bounds를 사용합니다.")]
    public BoxCollider playAreaCollider;

    // Y 축(높이)은 제한하지 않을 경우 true로 설정
    public bool ignoreY = true;

    private void LateUpdate()
    {
        if (playAreaCollider == null) return;

        Bounds bounds = playAreaCollider.bounds;
        Vector3 pos = transform.position;

        if (ignoreY)
        {
            pos.x = Mathf.Clamp(pos.x, bounds.min.x, bounds.max.x);
            pos.z = Mathf.Clamp(pos.z, bounds.min.z, bounds.max.z);
            // Y는 유지
        }
        else
        {
            pos.x = Mathf.Clamp(pos.x, bounds.min.x, bounds.max.x);
            pos.y = Mathf.Clamp(pos.y, bounds.min.y, bounds.max.y);
            pos.z = Mathf.Clamp(pos.z, bounds.min.z, bounds.max.z);
        }

        transform.position = pos;
    }
}