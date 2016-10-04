using UnityEngine;
using System.Collections;
using Zenject;
using System;

public class TestLoggerScript : ITickable {
    
	public TestLoggerScript () {
        Debug.Log("Hey, it worked!");
    }

    public void Tick () {
        Debug.Log("Ticking");
    }
}
