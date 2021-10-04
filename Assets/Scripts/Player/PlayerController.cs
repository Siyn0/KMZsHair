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
        //------------------Input.GetAxisRaw没有小数值，只有整数，不会产生缓动------------------
        //角色水平移动
        //按住D键，判断如果大于0，则向右开始移动
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            m_rg.velocity = new Vector2(MoveSpeed, m_rg.velocity.y);

        }
        //角色水平移动
        //按住A键，判断如果小于0，则向左开始移动
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            m_rg.velocity = new Vector2(-MoveSpeed, m_rg.velocity.y);

        }
        else
        //角色水平移动
        //松开按键，判断如果等于0，则停止移动
        {
            m_rg.velocity = new Vector2(0, m_rg.velocity.y);
        }


        if (Input.GetAxisRaw("Vertical") > 0)
        {
            m_rg.velocity = new Vector2(m_rg.velocity.x,MoveSpeed);
        }
        //角色水平移动
        //按住A键，判断如果小于0，则向左开始移动
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            m_rg.velocity = new Vector2(m_rg.velocity.x,- MoveSpeed);
        }
        else
        //角色水平移动
        //松开按键，判断如果等于0，则停止移动
        {
            m_rg.velocity = new Vector2(m_rg.velocity.x, 0);
        }
    }
}

