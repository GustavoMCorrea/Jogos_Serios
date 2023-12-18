using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody2D;
    private Animator playerAnimator;
    public float playerSpeed;
    private float playerInitialSpeed;
    public float playerRunSpeed;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();

        playerInitialSpeed = playerSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

        if (playerDirection.sqrMagnitude > 0)
        {
            playerAnimator.SetInteger("Movimento", 1);
        } 
        else
        {
            playerAnimator.SetInteger("Movimento", 0);
        }

        Flip();

        PlayerRun();

    }

    //Controle do Player
    void FixedUpdate()
    {
        playerRigidbody2D.MovePosition(playerRigidbody2D.position + playerDirection * playerSpeed * Time.fixedDeltaTime);
        
    }
    //Muda a dureção da animação do personagem
    void Flip()
    {
        if (playerDirection.x > 0)
        {
            transform.eulerAngles = new Vector2(0f, 0f);

        }
        else if (playerDirection.x < 0)
        {
            transform.eulerAngles = new Vector2(0f, 180f);
        }
    }

    void PlayerRun()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed = playerRunSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = playerInitialSpeed;
        }
    }

}
