using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class BirdController : MonoBehaviour
{
    [Header("Player Component References")]
    
    [SerializeField] private StateManager stateManager;
    [SerializeField] private Rigidbody2D rb;


    private void Start()
    {
        // Subscribes to the event OnJumpInput with the Jump Function
        // This effectively means that if the 
        if (stateManager != null)
        {
            stateManager.OnJumpInput += Jump;
        }
    }

    private void OnDestroy()
    {
        // Unsubscribes Jump from the event OnJumpInput
        if (stateManager != null)
        {
            stateManager.OnJumpInput -= Jump;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            stateManager.GameOver();
        } else if (other.CompareTag("AddScore"))
        {
            stateManager.IncreaseScore();
        }
    }

    private void FixedUpdate()
    {
        if (!StateManager.IsGameOver && (rb.transform.position.y < -5.5 || rb.transform.position.y > 5.5))
        {
            stateManager.GameOver();
        }
    }
    
    public void Jump()
    { 
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, 5f);
    }
    
}
