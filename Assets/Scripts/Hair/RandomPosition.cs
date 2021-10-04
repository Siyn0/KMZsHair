using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        transform.position = new Vector3(-44.0f + Random.Range(0, 88), 22.0f, 10.0f);
    }

}
