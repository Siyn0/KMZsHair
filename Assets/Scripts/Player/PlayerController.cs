using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 20.0f;

    private Collider2D PlayerCollider;


    /*private void Start()
    {
        PlayerCollider = transform.GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-MoveSpeed, 0,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(MoveSpeed, 0,0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, MoveSpeed,0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -MoveSpeed,0);
        }
    }*/
    private Rigidbody2D m_rg;

    void Start()
    {
        m_rg = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //------------------Input.GetAxisRawû��С��ֵ��ֻ�������������������------------------
        //��ɫˮƽ�ƶ�
        //��סD�����ж��������0�������ҿ�ʼ�ƶ�
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            m_rg.velocity = new Vector2(MoveSpeed, m_rg.velocity.y);

        }
        //��ɫˮƽ�ƶ�
        //��סA�����ж����С��0��������ʼ�ƶ�
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            m_rg.velocity = new Vector2(-MoveSpeed, m_rg.velocity.y);

        }
        else
        //��ɫˮƽ�ƶ�
        //�ɿ��������ж��������0����ֹͣ�ƶ�
        {
            m_rg.velocity = new Vector2(0, m_rg.velocity.y);
        }


        if (Input.GetAxisRaw("Vertical") > 0)
        {
            m_rg.velocity = new Vector2(m_rg.velocity.x,MoveSpeed);
        }
        //��ɫˮƽ�ƶ�
        //��סA�����ж����С��0��������ʼ�ƶ�
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            m_rg.velocity = new Vector2(m_rg.velocity.x,- MoveSpeed);
        }
        else
        //��ɫˮƽ�ƶ�
        //�ɿ��������ж��������0����ֹͣ�ƶ�
        {
            m_rg.velocity = new Vector2(m_rg.velocity.x, 0);
        }
    }
}

