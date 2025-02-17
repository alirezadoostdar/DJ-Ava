namespace DjAva.Application.Common;

public class Result
{
	public bool IsSuccess { get; set; }
	public bool IsFailure
		=> !IsSuccess;
	public string Message { get; set; }
	public Result()
		=> IsSuccess = true;
	public Result(string message)
	{
		IsSuccess = false;
		Message = message;
	}

	public static Result Failure(string msg)
		=> new Result(msg);

	public static Result Success()
		=> new();
}
