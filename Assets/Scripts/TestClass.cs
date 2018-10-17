using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TestClass {
    public TestClass()
    {
        var clickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
        //  コルーチンを意識しなくても非同期の処理を扱える
        //  MonoBehaviourじゃなくても使える(UniRxがコルーチン経由で呼び出してくれている)
        clickStream.Subscribe(_ => {
            Debug.Log("Button down");
            func();
        });
    }

    void func()
    {
        Debug.Log("関数呼び出し");
    }

}
