using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorVis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("cursor enabled");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        //showCursor = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
