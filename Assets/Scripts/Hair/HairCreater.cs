using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairCreater : MonoBehaviour
{
    public float ScreenWidth = 88.0f;
    public float CreateTime = 2.0f;
    public int MaxNumber = 100;

    public GameObject EndText;
    public GameObject QuitBT;
    public GameObject HairPref;

    private Vector3 TempPosition;
    
    private float t = 0.0f;
    /*private float PosX;
    private float PosY;
    private float PosZ;*/
    private int Number = 0;

    private void Start()
    {
        /*PosX = transform.position.x;
        PosY = transform.position.y;
        PosZ = transform.position.z;*/
    }

    private void FixedUpdate()
    {
        if (t >= CreateTime)
        {
            
            GameObject.Instantiate(HairPref);
            t = 0.0f;
            Number += 1;
        }
        t+=0.1f;
        if(Number >= MaxNumber)
        {
            EndText.SetActive(true);
            QuitBT.SetActive(true);
            Destroy(this.gameObject);
        }
    }
}
