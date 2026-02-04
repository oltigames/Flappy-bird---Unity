using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    
    // Prefab is short for fabricated object
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float spawnRate;
    [SerializeField] private float minHeight;
    [SerializeField] private float maxHeight;
    

    private void OnEnable()
    {
        InvokeRepeating(nameof(SpawnPipe), 0, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(SpawnPipe));
    }

    private void SpawnPipe()
    {
        float height = Random.Range(minHeight,  maxHeight);
        Instantiate(pipePrefab, new Vector2(13, height), transform.rotation);
        
    }
}
