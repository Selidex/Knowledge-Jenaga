using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestmyStack : MonoBehaviour
{

    // Update is called once per frame
    public void TestStack()
    {
            GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
            foreach(GameObject go in allObjects){
                if (go.name.Contains("Block"))
                    if(go.GetComponent<Renderer>().sharedMaterial.name == "Glass") 
                        Destroy(go);
            }
        
    }
}
