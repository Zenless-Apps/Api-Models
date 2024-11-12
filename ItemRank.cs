namespace ZZZ.ApiModels;

using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter<ItemRank>))]
public enum ItemRank {
	B,
	A,
	S
}