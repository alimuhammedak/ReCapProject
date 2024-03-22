namespace Core.Utilities.Result
{
    public interface IResult
    {
        string Message { get; }
        bool IsSuccess { get; }
    }
}
