using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        var move = new Vector3(x, y, 0) * (Time.deltaTime * speed);

        _characterController.Move(move);
    }
}
