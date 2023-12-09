using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(0, 5)] float InputDelay = 0.5f;
    [SerializeField, Range(0, 100)] float InputForce = 5f;


    private float InputDelayTimer = 0f;
    private Rigidbody2D rb;
    private GameManager gameManager;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameManager.Instance;
    }

    void Update()
    {

        InputDelayTimer = InputDelayTimer + Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Mouse0) && InputDelayTimer >= InputDelay && gameManager.ReturnPlayerState())
        {
            rb.velocity = new Vector2(0, InputForce);
        }
    }
}
