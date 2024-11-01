namespace ZZZ.ApiModels;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ItemRank {
	B,
	A,
	S
}