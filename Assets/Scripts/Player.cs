using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Monetization;
using System.Collections;

public class Player : MonoBehaviour
{
    public GameObject Youlose;
    public static bool lose = false;

    public int a = 15;
    public static float Score = 0f;
    public Text score;
    public float speed;

    void Start()
    {
        score.text = Score.ToString();
        Resume();
        if (Monetization.isSupported) Monetization.Initialize("3828737", false);
    }

    void Update()
    {
        if (lose == false)
        {
            Score += a * Time.deltaTime;
            score.text = Mathf.Round(Score).ToString();
            PlayerLose();
        }
    }

    void Awake()
    {
        lose = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other.gameObject.tag == "Bomb")
            {
                Youlose.SetActive(true);
                Pause();
            }
            else
                Resume();
        }
    }

    public void ClickExit()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void CkickProdol()
    {
        if (Monetization.IsReady("rewardedVideo"))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowRezult;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
            ad.Show(options);
        }
    }
    void HandleShowRezult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            lose = false;
            Youlose.SetActive(false);
            Resume();
        }
        if (result == ShowResult.Skipped)
        {

        }
        if (result == ShowResult.Failed)
        {

        }
    }

    void Pause()
    {
        Time.timeScale = 0f;
    }
    void Resume()
    {
        Time.timeScale = 1f;
    }
    void PlayerLose()
    {
        if (PlayerPrefs.GetInt("Score") < Score)
            PlayerPrefs.SetFloat("Score", Score);
    }

    private void FixedUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position,
                new Vector2(mousePos.x, transform.position.y),
                speed * Time.deltaTime);
        if (transform.position.x > mousePos.x)
            Right();
        else if (transform.position.x < mousePos.x)
            Left();
    }

    public Sprite[] sprites = new Sprite[2];
    public void Right()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
    }
    public void Left()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
    }
}