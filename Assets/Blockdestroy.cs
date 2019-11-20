using UnityEngine;
using System.Collections;
using DLLTest;

public class Blockdestroy : MonoBehaviour {
    public AddScore addScore = new AddScore();
     void Start()
     {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 30f;  
     }
    void Update ()
    {
  
        if (transform.position.y < -2f)
        {
            //Score.scoreAmount++;
            Score.scoreAmount=addScore.Increase(Score.scoreAmount);
            Destroy(gameObject);
        }
	}
}
