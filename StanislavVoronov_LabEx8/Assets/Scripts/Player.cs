using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    
    private Rigidbody2D _rigidbody;

    private int _score = 0;

    private ScoreUI _UI;
    
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _UI = FindObjectOfType<ScoreUI>();
    }

    private void Update()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        _rigidbody.AddForce(Vector2.right * (speed * horizontalMovement * Time.deltaTime), ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        var fallingObject = col.gameObject.GetComponent<FallingObject>();
        if ( fallingObject != null)
        {
            fallingObject.Reset();
            _score++;
            _UI?.UpdateScore(_score);
        }
    }
}
