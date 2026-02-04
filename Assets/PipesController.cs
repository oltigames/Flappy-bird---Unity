using System.Timers;
using UnityEngine;

public class PipesController : MonoBehaviour
{
    
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float pipeSpeedx;
    

    void FixedUpdate()
    {
        transform.position += new Vector3(pipeSpeedx / -10f, 0f, 0f);
        
        if (gameObject.transform.position.x < -15 && gameObject.transform.position.y < 50)
        {
            Destroy(gameObject);
        }
    }
    
}
