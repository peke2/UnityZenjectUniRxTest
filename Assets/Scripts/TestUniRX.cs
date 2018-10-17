using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UniRx;

public class TestUniRX : MonoBehaviour {

    TestClass tc;

	// Use this for initialization
	void Start () {
        //var clickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
        //clickStream.Subscribe(_ =>{
        //    Debug.Log("Button down");
        //    func();
        //});
        tc = new TestClass();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //void func()
    //{
    //    Debug.Log("関数呼び出し");
    //}
}
