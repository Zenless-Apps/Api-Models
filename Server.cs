// ReSharper disable InconsistentNaming
namespace ZZZ.ApiModels;

using System.ComponentModel;
using System.Text.Json.Serialization;

[JsonConverter(typeof(JsonStringEnumConverter<Server>))]
public enum Server : sbyte {
	Auto = -1,
	[Description("prod_gf_us")]
	America,
	[Description("prod_gf_jp")]
	Asia,
	[Description("prod_gf_eu")]
	Europe,
	[Description("prod_gf_sg")]
	TW_HK_MO,
}