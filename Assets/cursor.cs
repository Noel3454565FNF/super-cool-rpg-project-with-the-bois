using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour
{
    
    void Update()
    {
        this.gameObject.transform.position = Input.mousePosition;  
    }
}
