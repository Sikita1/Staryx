using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BombDown : MonoBehaviour
{
    public GameObject Bombe;

    void Start()
    {
        StartCoroutine(Span());
    }

    IEnumerator Span()
    {
        while (!Player.lose)
        {
            if (Player.Score < 100)
            {
                Instantiate(Bombe, new Vector3(Random.Range(-2.2f, 2.2f), 5.5f), Quaternion.identity);
                yield return new WaitForSeconds(2f);
                FallBomb.FallSpeead = 1f;
            }
            else if (Player.Score >= 100 && Player.Score < 199)
            {
                Instantiate(Bombe, new Vector3(Random.Range(-2.2f, 2.2f), 5.5f), Quaternion.identity);
                yield return new WaitForSeconds(1f);
                FallBomb.FallSpeead = 1.5f;
            }
            else if (Player.Score >= 200 && Player.Score < 299)
            {
                Instantiate(Bombe, new Vector3(Random.Range(-2.2f, 2.2f), 5.5f), Quaternion.identity);
                yield return new WaitForSeconds(0.8f);
                FallBomb.FallSpeead = 2f;
            }
            else if (Player.Score >= 300 && Player.Score < 399)
            {
                Instantiate(Bombe, new Vector3(Random.Range(-2.2f, 2.2f), 5.5f), Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
                FallBomb.FallSpeead = 2.5f;
            }
            else if (Player.Score >= 400 && Player.Score < 499)
            {
                Instantiate(Bombe, new Vector3(Random.Range(-2.2f, 2.2f), 5.5f), Quaternion.identity);
                yield return new WaitForSeconds(0.3f);
                FallBomb.FallSpeead = 3f;
            }
            else if (Player.Score >= 500 && Player.Score < 9999)
            {
                Instantiate(Bombe, new Vector3(Random.Range(-2.2f, 2.2f), 5.5f), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                FallBomb.FallSpeead = 4f;
            }
        }
    }

}