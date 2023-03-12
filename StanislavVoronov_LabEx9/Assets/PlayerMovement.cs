using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;


    private Controls _controls;
    private CharacterController _controller;
    
    private bool _isMovingUp;
    private bool _isMovingSide;

    private Vector2 _direction;

    private void Awake()
    {
        _controls = new Controls();
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _controls.Player.MoveSide.performed += OnMoveSideSwitch;
        _controls.Player.MoveVertical.performed += OnMoveUpSwitch;
    }

    private void Update()
    {
        if (_isMovingUp || _isMovingSide) Move();
    }

    private void Move()
    {
        _controller.Move(_direction.normalized * (speed * Time.deltaTime));
    }

    private void OnMoveSideSwitch(InputAction.CallbackContext obj)
    {
        if (!_isMovingSide)
        {
            var moveSide = obj.ReadValue<float>();
            _direction.x = moveSide;
        }
        else
        {
            _direction.x = 0.0f;
        }

        _isMovingSide = !_isMovingSide;
    }


    private void OnMoveUpSwitch(InputAction.CallbackContext obj)
    {
        if (!_isMovingUp)
        {
            var moveSide = obj.ReadValue<float>();
            _direction.y = moveSide;
        }
        else
        {
            _direction.y = 0.0f;
        }

        _isMovingUp = !_isMovingUp;
    }
}
