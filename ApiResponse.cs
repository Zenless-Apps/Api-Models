namespace ZZZ.ApiModels;

using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

public class ApiResponse <T> {
	
	public T? Data { get; set; }
	
	public string Message { get; set; } = string.Empty;
	
	[JsonPropertyName("retcode")]
	public ApiCode RetCode { get; set; }
}

public class ApiResponse : ApiResponse<JsonObject> {
	public static ApiResponse<T> Error<T>(string message, ApiCode code = ApiCode.Error) {
		return new()
		{
			Data = default,
			RetCode = code,
			Message = message
		};
	}
	
	public static ApiResponse<bool?> Error(string message, ApiCode code = ApiCode.Error) {
		return new()
		{
			Data = null,
			RetCode = code,
			Message = message
		};
	}
	
	public static ApiResponse<T> With<T>(T data, string message = "OK", ApiCode code = ApiCode.Ok) {
		return new ApiResponse<T> {
			Data = data,
			RetCode = code,
			Message = message
		};
	}
}