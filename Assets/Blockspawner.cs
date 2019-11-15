using UnityEngine;

public class Blockspawner : MonoBehaviour {
    public Transform[] spawnpoint;
    public Object Blockprefab;
    private float timetospawn ;
    public float timebetweenspawn;
    // Use this for initialization
	void SpawnBlock () {
        int RandomIndex = Random.Range(0, spawnpoint.Length);
        for(int i = 0; i < spawnpoint.Length; i++)
        {
            if (RandomIndex != i)
            {
                Instantiate(Blockprefab, spawnpoint[i].position, Quaternion.identity);
            }
           
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time >= timetospawn)
        {
            SpawnBlock();
            timetospawn = Time.time + timebetweenspawn;

        }
	}
}
