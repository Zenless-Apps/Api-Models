namespace ZZZ.ApiModels;

using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

public class ApiResponse <T> {
	
	public T? Data { get; set; }
	
	public string Message { get; set; } = string.Empty;
	
	[JsonPropertyName("retcode")]
	public int RetCode { get; set; }
}

public class ApiResponse : ApiResponse<JsonObject> {
	public static ApiResponse<T> Error<T>(string message, int code = 1) {
		return new ApiResponse<T> {
			Data = default,
			RetCode = code,
			Message = message
		};
	}
	
	public static ApiResponse<T> With<T>(T data, string message = "OK", int code = 0) {
		return new ApiResponse<T> {
			Data = data,
			RetCode = code,
			Message = message
		};
	}
}