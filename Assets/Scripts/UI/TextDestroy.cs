using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDestroy : MonoBehaviour
{
    public float DestroyTime = 10f;
    void OnEnable()
    {
        Invoke("DestroyIt",DestroyTime);
    }
    private void DestroyIt()
    {
        Destroy(this.gameObject);
    }

}
