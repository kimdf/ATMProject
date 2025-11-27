using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    public bool isJumpPressed = false;  // 점프 키가 눌려 있는 상태를 저장

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpPressed = true;    // 스페이스를 눌렀을 때 true
            Debug.Log("점프 키 눌림");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumpPressed = false;   // 스페이스를 뗐을 때 false
            Debug.Log("점프 키 해제");
        }

        if (isJumpPressed)
        {
            // 스페이스를 누르고 있는 동안 실행
            HandleJump();
        }
        float axisX = Input.GetAxis("Horizontal");     // 부드럽게 변함
        float rawX = Input.GetAxisRaw("Horizontal");   // 즉시 -1, 0, 1

       // Debug.Log($"Axis: {axisX}, Raw: {rawX}");
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 move = new Vector2(moveX, moveY).normalized;
        rb.velocity = move * speed;
    }
    void HandleJump()
    {
        Debug.Log("점프 처리 중...");
        // 점프 충전, 부스트, 착지 준비 등 처리
    }

    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
