using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallBomb : MonoBehaviour
{
    [SerializeField]
    public static float FallSpeead = 0.7f;



    void Update()
    {
        if (transform.position.y < -6.2)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(0, FallSpeead * Time.deltaTime, 0);
    }
}
