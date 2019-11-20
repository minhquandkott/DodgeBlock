using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class Player : MonoBehaviour {

    // Use this for initialization
    public float speed;
    private Rigidbody2D rb;
    private AudioSource hitSound;
    public float mapWidth;
    void Start () {
        hitSound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        //float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float x = 0;
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).position.x < Screen.width / 2)
            {
               x = Mathf.Lerp(x, -1, Time.deltaTime * speed);
            }
            else
            {
                x = Mathf.Lerp(x, 1, Time.deltaTime * speed);
            }
        }
        else
        {
            x = Mathf.Lerp(x, 0, Time.deltaTime * speed);
        }
        Vector2 newPosition = rb.position + Vector2.right * x;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);
	}


    void OnCollisionEnter2D()
    {
        hitSound.Play();
        FindObjectOfType<GameManage>().EndGame();
    }
}
