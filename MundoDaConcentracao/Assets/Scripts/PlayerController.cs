using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRigidbody2D;
    private Animation playerAnimator;
    public float playerSpeed;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        playerDirection = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

        if (playerDirection.sqrMagnitude > 0)
        {

        }

    }

    //Controle do Player
    void FixedUpdate()
    {
        playerRigidbody2D.MovePosition(playerRigidbody2D.position + playerDirection * playerSpeed * Time.fixedDeltaTime);
        
    }
}
