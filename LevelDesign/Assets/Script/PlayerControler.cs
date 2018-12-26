using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private Animator animator;
    SpriteRenderer sr;
    [HideInInspector] public Rigidbody2D rb;
    [SerializeField] private int speed; //キャラクターの移動スピード
    [SerializeField] private short jumpPower; //ジャンプ力
    [SerializeField] private short jumpCount; //ジャンプ回数
    [SerializeField] private float fallSpeed; //落下速度
    private short startJumpCount; //ジャンプカウントの代入用変数
    [SerializeField] private Sprite jumpImage; //ジャンプ時の差し替え画像用
    [SerializeField] private Sprite fallImage; //落下時の差し替え画像用
    private bool isTouched; //接地判定
    [SerializeField] private Vector2 respornPos;//リスポーン地点の設定

    [SerializeField] ContactFilter2D filter2d;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetBool("IsClouch", false);
        animator.SetFloat("RunSpeed", 0.0f);
        startJumpCount = jumpCount;
        rb.gravityScale = fallSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("IsClouch", true);
            rb.gravityScale = 3 * fallSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (animator.GetBool("IsClouch")) return;
            Move(Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jumpCount == 0) return;
            if (isTouched)
            {
                jumpCount++;

            }
            Jump();
        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) 
        {
            animator.SetBool("IsClouch", false);
            rb.gravityScale = fallSpeed;
        }
        
        if (rb.velocity.y < 0)
        {
            animator.enabled = false;
            sr.sprite = fallImage;
        }
        animator.SetFloat("RunSpeed", Mathf.Abs(rb.velocity.x)); //走るのをやめたらアイドル状態に戻す
        
    }
    //落下した時のリスポーン処理
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            transform.position = respornPos;
        }
        if (collision.gameObject.tag == "Cherry")
        {
            Debug.Log("Clear!");
        }
    }
    //地面から離れた時の処理
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" )
        {
            isTouched = false;
        }
    }
    //地面についた時の処理
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && rb.IsTouching( filter2d ) )
        {
            //ジャンプカウントを戻す
            jumpCount = startJumpCount;

            //ジャンプ時、落下時のスプライトを解除してアニメーションをつける
            sr.sprite = null;
            animator.enabled = true;

            //接地判定をつける
            isTouched = true;
        }
    }
    
    private void Move(float value)
    {
        float moveValue = speed;

        rb.velocity = new Vector2(value * moveValue, rb.velocity.y);

        // 移動方向にキャラクターを向ける
        if (value > 0)
        {
            sr.flipX = false;
        }
        else if (value < 0)
        {
            sr.flipX = true;
        }
    }
    private void Jump()
    {
        sr.sprite = jumpImage;
        animator.enabled = false;

        //ジャンプの回数を減らしてジャンプする
        jumpCount--;
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
    }
    
}
