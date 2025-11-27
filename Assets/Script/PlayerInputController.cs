using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : TopDownController
{
    public void OnInteract(InputValue value)
    {
        if (value.isPressed) // 상호작용 키를 눌렀다면
        {
            CallInteractEvent(); // 상호작용 이벤트 실행 함수 호출
        }
    }

    private void CallInteractEvent()
    {
        throw new NotImplementedException();
    }
}

public class InputValue
{
    public bool isPressed { get; internal set; }
}

public class TopDownController
{
}