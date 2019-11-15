using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour {

    // Use this for initialization
    public float speed;
    private Rigidbody2D rb;
    public float mapWidth;
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);
	}
     void OnCollisionEnter2D()
    {
        FindObjectOfType<GameManage>().EndGame();
    }
}
