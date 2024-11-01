namespace ZZZ.ApiModels;

using System.ComponentModel;

public enum Server {
	[Description("prod_gf_us")]
	America,
	[Description("prod_gf_jp")]
	Asia,
	[Description("prod_gf_eu")]
	Europe
}