using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestInspecter3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
	    
    }

    // Update is called once per frame
    void Update()
    {
	    if(Input.GetKey(KeyCode.M))
	    {
	    	DebugTest();
	    }
    }
    
	private void DebugTest()
	{
		Debug.Log("InspecterLog テスト");
	}
}
