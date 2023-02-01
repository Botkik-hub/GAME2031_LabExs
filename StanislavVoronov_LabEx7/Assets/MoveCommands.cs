using UnityEngine;

public abstract class MoveCommand : ICommandU
{
    private readonly Transform _target;
    private readonly Vector3 _direction;

    protected MoveCommand(Transform transform, Vector3 direction)
    {
        _target = transform;
        _direction = direction;
    }
    
    public void Execute()
    {
        _target.Translate(_direction);
    }

    public void Undo()
    {
        _target.Translate(-_direction);
    }
}

public class MoveCommandUp : MoveCommand
{
    public MoveCommandUp(Transform transform) : base(transform, Vector3.up)
    {
    }
}

public class MoveCommandDown : MoveCommand
{
    public MoveCommandDown(Transform transform) : base(transform, Vector3.down)
    {
    }
}

public class MoveCommandLeft : MoveCommand
{
    public MoveCommandLeft(Transform transform) : base(transform, Vector3.left)
    {
    }
}

public class MoveCommandRight : MoveCommand
{
    public MoveCommandRight(Transform transform) : base(transform, Vector3.right)
    {
    }
}