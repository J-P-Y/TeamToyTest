using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Rigidbody2D target;

    bool isLive;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isLive)
            return;

        Vector2 dirvec = target.position - rigid.position;
        Vector2 nexxtVec = dirvec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nexxtVec);
        rigid.velocity = Vector2.zero;
    }
    void LateUpdate()
    {
        if (isLive)
            return;
        spriter.flipX = target.position.x < rigid.position.x;
    }

    void OnEnable()
    {
        target = GameManager.Instance.player.GetComponent<Rigidbody2D>();
        
    }

}
