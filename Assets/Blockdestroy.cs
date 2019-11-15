using UnityEngine;
using System.Collections;

public class Blockdestroy : MonoBehaviour {
     void Start()
     {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 30f;  
     }
    void Update ()
    {
        if (transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
	}
}
