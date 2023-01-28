using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float cooldown;
    [SerializeField] private float spawnRange;
    
    private float _timeSinceLastSpawn;
    private ObjectPool _pool;
    
    private void Start()
    {
        _timeSinceLastSpawn = 0;
        _pool = FindObjectOfType<ObjectPool>();
    }

    private void Update()
    {
        _timeSinceLastSpawn += Time.deltaTime;
        if (_timeSinceLastSpawn >= cooldown)
        {
            _timeSinceLastSpawn = 0.0f;
            Spawn();
        }
    }

    private Vector2 GetSpawnPosition()
    {
        Vector2 position = transform.position;
        position.x = Random.Range(-1.0f, 1.0f) * spawnRange;
        return position;
    }
    
    private void Spawn()
    {
        var temp = _pool.GetObject();
        temp.transform.position = GetSpawnPosition();
    }
}
