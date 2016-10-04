using UnityEngine;
using System.Collections;

public interface IOtherDependency
{
    void PrintLogStatement();
}

public class OtherDependency : IOtherDependency {

	public void PrintLogStatement()
    {
        Debug.Log("Logging From Other Depdency");
    }
}
