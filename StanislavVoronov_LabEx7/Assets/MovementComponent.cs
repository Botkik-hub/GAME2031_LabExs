using UnityEngine;

public class MovementComponent : MonoBehaviour
{
    private CommandManager _commandManager;
    
    private void Start()
    {
        _commandManager = CommandManager.Instance;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            var command = new MoveCommandDown(transform);
            command.Execute();
            _commandManager.AddCommand(command);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            var command = new MoveCommandUp(transform);
            command.Execute();
            _commandManager.AddCommand(command);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            var command = new MoveCommandLeft(transform);
            command.Execute();
            _commandManager.AddCommand(command);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            var command = new MoveCommandRight(transform);
            command.Execute();
            _commandManager.AddCommand(command);

        }
    }
}
