using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Player") {
            collision.gameObject.transform.SetParent(transform); 
            //collision.gameObject.transform refers to "Player"
            //transform paramter refers to transform component of what object this script is applied to, in this case "StickPlatform"
        }
    }

    private void OnCollisionExit(Collision collision) {
        if (collision.gameObject.name == "Player") {
            collision.gameObject.transform.SetParent(null); 
            //collision.gameObject.transform refers to "Player"
            //transform paramter refers to transform component of what object this script is applied to, in this case "StickPlatform"
        }
    }
}
