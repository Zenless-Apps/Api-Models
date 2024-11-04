#pragma warning disable CS0618 // Type or member is obsolete
namespace ZZZ.ApiModels.Serialization;

using System.Text.Json.Serialization;
using Responses;

[JsonSerializable(typeof(Agent[]))]
[JsonSerializable(typeof(Agent.Weapon[]))]
[JsonSerializable(typeof(Agent.Disc[]))]
[JsonSerializable(typeof(Agent.Disc.Stat[]))]
[JsonSerializable(typeof(Agent.Skill[]))]
[JsonSerializable(typeof(Agent.Mindscape[]))]

[JsonSerializable(typeof(Proxy[]))]
[JsonSerializable(typeof(HoyolabUser[]))]

/*
 * Api response models
 */
[JsonSerializable(typeof(ApiResponse<Agent>[]))]
[JsonSerializable(typeof(ApiResponse<Proxy>[]))]
[JsonSerializable(typeof(ApiResponse[]))]
public partial class ZenlessApiJsonContext : JsonSerializerContext {}