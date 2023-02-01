using UnityEngine;

public class ColorCommand : ICommand
{
    private readonly SpriteRenderer _target;
    private readonly Color _newColor;

    public ColorCommand(SpriteRenderer renderer, Color newColor)
    {
        _target = renderer;
        _newColor = newColor;
    }
    
    public void Execute()
    {
        _target.color = _newColor;
    }
}
