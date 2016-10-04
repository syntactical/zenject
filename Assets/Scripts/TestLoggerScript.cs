using UnityEngine;
using System.Collections;
using Zenject;
using System;

public class TestLoggerScript : ITickable {

    IOtherDependency otherDependency;

	public TestLoggerScript (IOtherDependency otherDependency) {
        this.otherDependency = otherDependency;
        this.otherDependency.PrintLogStatement();
    }

    public void Tick () {
        Debug.Log("Ticking...");
   }
}
