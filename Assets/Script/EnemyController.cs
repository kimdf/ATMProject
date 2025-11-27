using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float moveSpeed = 2f; // 적 이동 속도! (유니티 인스펙터에서 조절 가능)
    public float patrolRange = 5f; // 얘가 얼마나 넓게 순찰할지 정하는 범위야. 중앙으로부터 좌우로 2.5씩 움직이는 셈이지!

    private Vector2 initialPosition; // 시작 지점을 기억해둘 변수
    private int moveDirection = 1; // 1이면 오른쪽, -1이면 왼쪽으로 움직여

    void Start()
    {
        initialPosition = transform.position; // 게임 시작할 때 적의 현재 위치를 저장해둬!
    }

    void Update()
    {
        // 현재 정해진 방향으로 계속 이동하는 코드야!
        transform.Translate(Vector2.right * moveDirection * moveSpeed * Time.deltaTime);

        // 순찰 범위를 벗어나면 방향을 바꿔야겠지?
        if (transform.position.x > initialPosition.x + patrolRange / 2f)
        {
            moveDirection = -1; // 이제 왼쪽으로!
        }
        else if (transform.position.x < initialPosition.x - patrolRange / 2f)
        {
            moveDirection = 1; // 다시 오른쪽으로!
        }
    }
}
