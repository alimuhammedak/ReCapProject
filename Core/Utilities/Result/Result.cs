namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public string Message { get; }
        public bool IsSuccess { get; }
        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public Result(bool isSuccess, string message) : this(isSuccess)
        {
            Message = message;
        }



    }
}
