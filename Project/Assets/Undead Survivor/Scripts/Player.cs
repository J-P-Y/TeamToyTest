using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;

    SpriteRenderer spriter;
    Rigidbody2D rigid;
    Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriter = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    

    void Update()
    {
        // rigid.AddForce(inputVec); // 힘을 준다
        // rigid.velocity = inputVec; // 속도 제어
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec); // 위치 이동
        
    }
    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
        
    }
    void LateUpdate()
    {
        animator.SetFloat("Speed", inputVec.magnitude);
        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
        
    }
}
