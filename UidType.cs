namespace ZZZ.ApiModels;

using System.Text.Json.Serialization;

/// <summary>
/// Type of unique identifier.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<UidType>))]
public enum UidType {
	/**
	 * Unique identifier for a proxy of Zenless Zone Zero.
	 */
	Proxy,
	/**
	 * Unique identifier for a hoyolab user.
	 */
	Hoyolab,
}