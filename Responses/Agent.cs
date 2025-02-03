// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace ZZZ.ApiModels.Responses;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Agent {
	public uint ProxyUid { get; set; }
	
	[JsonIgnore]
	public Proxy Proxy { get; set; } = null!;
	
	public uint Uid { get; set; }
	
	readonly int _level;
	
	public required Agents Id { get; set; }
	
	public DateTime LastUpdate { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public int Level
	{
		get => _level;
		init
		{
			_level = value;
			if (value > 0) Ascension = A(_level);
		}
	}

	static AscensionState A(int level) {
		return level switch
		{
			>= 60 => AscensionState.A60_60,
			> 50 => AscensionState.A50_60,
			50 => AscensionState.A50_50,
			> 40 => AscensionState.A40_50,
			40 => AscensionState.A40_40,
			> 30 => AscensionState.A30_40,
			30 => AscensionState.A30_30,
			> 20 => AscensionState.A20_30,
			20 => AscensionState.A20_20,
			> 10 => AscensionState.A10_20,
			10 => AscensionState.A10_10,
			_ => AscensionState.A1_10
		};
	}

	public AscensionState Ascension { get; set; }

	public int Cinema { get; set; }

	public Weapon? Engine { get; set; }

	[MaxLength(30)]
	public required string Name { get; set; }

	public List<Property> Properties { get; set; } = [];
	
	public class Property {
		public required string Name { get; set; }
		public required int Id { get; set; }
		public double Base { get; set; }
		public double Add { get; set; }
		public double Final { get; set; }
	}

	public class Weapon {
		public uint Uid { get; set; }
		
		readonly int _level;
		
		public Engines Id { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public int Level
		{
			get => _level;
			init
			{
				_level = value;
				if (value > 0) Ascension = A(_level);
			}
		}

		public int Refinement { get; set; } = 1;
		
		[MaxLength(30)]
		public required string Name { get; set; }
		
		public AscensionState Ascension { get; set; }
		
		public required Stat MainStat { get; set; }
		
		public required Stat SubStat { get; set; }
		
		public DateTime LastUpdate { get; set; }
	}

	public required List<Skill> Skills { get; set; }

	public class Skill {
		public Skills Id { get; set; }

		public int Level { get; set; }
		
		public string Title { get; set; } = "Unknown";
	}

	public required List<Disc> Discs { get; set; }

	public class Disc {
		public uint Uid { get; set; }
		
		public required Discs Id { get; set; }

		public required int Level { get; set; }

		[MaxLength(30)]
		public string Name { get; set; } = "Unknown";

		public required ItemRank Rank { get; set; }

		public required int Slot { get; set; }

		public required Stat? MainStat { get; set; }

		public required List<Stat> SubStats { get; set; }
		
		public DateTime LastUpdate { get; set; }
	}
	
	public class Stat {
		public required AgentStats Id { get; set; }
			
		[MaxLength(30)]
		public string Name { get; set; } = "Unknown";

		public required string Value { get; set; }
			
		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		[DefaultValue(0)]
		public int Rolls { get; set; } = 0;
	}
}