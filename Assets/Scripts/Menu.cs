using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Bomb;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            Instantiate(Bomb, new Vector3(4f, Random.Range(-2.5f, 3.2f), 0), Quaternion.identity);
            yield return new WaitForSeconds(3.5f);
        }
    }

    public void ClickGo()
    {
        SceneManager.LoadScene("Game");
        Player.Score = 0;
        Time.timeScale = 0f;
    }
}

