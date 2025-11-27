using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseController
{
    private Camera camera;

    protected override void Start()
    {
        base.Start();
        camera = Camera.main;
    }

    protected override void HandleAction()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        movementDirection = new Vector2(horizontal, vertical).normalized;

        Vector2 mousePosition = Input.mousePosition;
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);
        lookDirection = (worldPos - (Vector2)transform.position);

        if (lookDirection.magnitude < .9f)
        {
            lookDirection = Vector2.zero;
        }
        else
        {
            lookDirection = lookDirection.normalized;
        }

        isAttacking = Input.GetMouseButton(0);
    }


    void LateUpdate()
    {
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 screenPos = Input.mousePosition;
                screenPos.z = 10f;
                // 카메라로부터의 거리 (Orthographic이면 생략 가능)

                Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
                //Debug.Log($"화면 좌표: {screenPos}, 월드 좌표: {worldPos}");
            }
        }
    }

    internal void Init(GameManager gameManager)
    {
        throw new NotImplementedException();
    }
}