using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallBmb : MonoBehaviour
{
    [SerializeField]
    private float FallSpeed = 0.7f;

    void Update()
    {
        if (transform.position.x < -7)
        {
            Destroy(gameObject);
        }
        transform.position -= new Vector3(FallSpeed * Time.deltaTime, 0, 0);
    }


}
