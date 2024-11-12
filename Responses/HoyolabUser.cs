namespace ZZZ.ApiModels.Responses;

using System.ComponentModel.DataAnnotations;

public class HoyolabUser {
	
	public uint Uid { get; set; }
	
	public uint? ProxyUid { get; set; }
	
	public Proxy? Proxy { get; set; }
	
	[MaxLength(250)]
	public string Avatar { get; set; } = string.Empty;
	
	[MaxLength(250)]
	public string Pendant { get; set; } = string.Empty;
	
	[MaxLength(20)]
	public string Name { get; set; } = string.Empty;
	
	[MaxLength(200)]
	public string Bio { get; set; } = string.Empty;
	
	public DateTime LastUpdate { get; set; }
}