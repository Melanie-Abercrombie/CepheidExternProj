using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openCloseBox : MonoBehaviour
{
    bool opened=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void  OnTriggerEnter(Collider other) {
        Debug.Log("collided");
        if(other.gameObject.tag=="Player"){
            if(!opened){
                Debug.Log("open");
                opened=true;
            }
            else{
                Debug.Log("close");
                opened=false;
            }
        }
    }
}
