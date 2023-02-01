using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer _renderer;
    private CommandManager _commandManager;
    
    [SerializeField] private Color original;
    [SerializeField] private Color other;
    private void Start()
    {
        _commandManager = CommandManager.Instance;

        _renderer = GetComponent<SpriteRenderer>();
        var command = new ColorCommand(_renderer, original);
        command.Execute();
        _commandManager.AddCommand(command);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            var nextColor = _renderer.color == original ? other : original;
            var command = new ColorCommand(_renderer, nextColor);
            command.Execute();
            _commandManager.AddCommand(command);
        }
    }
}
