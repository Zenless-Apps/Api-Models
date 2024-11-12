#pragma warning disable CS0618 // Type or member is obsolete
namespace ZZZ.ApiModels.Serialization;

using System.Text.Json.Serialization;
using Responses;

[JsonSerializable(typeof(Agent[]))]
[JsonSerializable(typeof(Agent.Weapon[]))]
[JsonSerializable(typeof(Agent.Disc[]))]
[JsonSerializable(typeof(Agent.Stat[]))]
[JsonSerializable(typeof(Agent.Skill[]))]
[JsonSerializable(typeof(Agent.Property[]))]
[JsonSerializable(typeof(List<Agent.Disc>))]
[JsonSerializable(typeof(List<Agent.Stat>))]
[JsonSerializable(typeof(List<Agent.Skill>))]
[JsonSerializable(typeof(List<Agent.Property>))]

[JsonSerializable(typeof(Proxy[]))]
[JsonSerializable(typeof(HoyolabUser[]))]

[JsonSerializable(typeof(DateTime[]))]

/*
 * Api response models
 */
[JsonSerializable(typeof(ApiResponse<Agent>[]))]
[JsonSerializable(typeof(ApiResponse<Agents[]>[]))]
[JsonSerializable(typeof(ApiResponse<Proxy>[]))]
[JsonSerializable(typeof(ApiResponse<HoyolabUser>[]))]
[JsonSerializable(typeof(ApiErrorResponse[]))]
[JsonSerializable(typeof(ApiResponse[]))]

public partial class ZenlessApiJsonContext : JsonSerializerContext {}