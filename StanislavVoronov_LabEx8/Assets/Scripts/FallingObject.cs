using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] private float offset = 10.0f;
    
    private float _minY;

    private void Start()
    {
        _minY = FindObjectOfType<Player>().transform.position.y - offset;
    }

    private void OnDisable()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
    
    private void Update()
    {
        if (transform.position.y < _minY)
        {
            Reset();
        }
    }

    public void Reset()
    {
        FindObjectOfType<ObjectPool>().ReturnObject(gameObject);
    }
}
