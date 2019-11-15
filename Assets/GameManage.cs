using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManage : MonoBehaviour
{
    public float slowness = 10f;
    public void EndGame()
    {
        StartCoroutine(Restartlevel());
    } 

    IEnumerator Restartlevel()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        yield return new WaitForSeconds(1f / slowness);
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}	
