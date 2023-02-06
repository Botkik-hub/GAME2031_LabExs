using System;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
    public static CommandManager Instance { get; private set; }
    
    private List<ICommand> _commands;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        _commands = new List<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }

    private void UndoCommand()
    {
        if (_commands.Count == 0)
        {
            print("No commands to undo");
            return;
        }

        try
        {
            var commandU = (ICommandU)_commands[^1];
            commandU.Undo();
        }
        catch (InvalidCastException)
        {
            print("Command can not be undone");
        }
        _commands.RemoveAt(_commands.Count - 1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            UndoCommand();
        }
    }
}
