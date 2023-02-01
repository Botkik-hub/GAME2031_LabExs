public interface ICommand
{
    void Execute();
}

public interface ICommandU : ICommand
{
    void Undo();
}
