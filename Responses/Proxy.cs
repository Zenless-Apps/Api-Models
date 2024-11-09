namespace ZZZ.ApiModels.Responses;

using System.ComponentModel.DataAnnotations;

public class Proxy {
	
	public uint Uid { get; set; }
	
	public Server Server { get; set; }
	
	public uint? HoyolabUserUid { get; set; }
	
	public HoyolabUser? HoyolabUser { get; set; }
	
	[MaxLength(250)]
	public string Avatar { get; set; } = string.Empty;
	
	[MaxLength(50)]
	public string Name { get; set; } = string.Empty;
	
	public int Level { get; set; }
	
	public List<Agent> Agents { get; set; } = [];
}