namespace ZZZ.ApiModels.Responses;

using System.ComponentModel.DataAnnotations;

public class Proxy {
	
	public uint Uid { get; set; }
	
	public uint? HoyolabId { get; set; }
	
	[MaxLength(250)]
	public string Avatar { get; set; } = string.Empty;
	
	[MaxLength(50)]
	public string Name { get; set; } = string.Empty;
	
	public int Level { get; set; }
}