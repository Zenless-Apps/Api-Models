// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace ZZZ.ApiModels.Responses;

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class Agent {
	public uint ProxyUid { get; init; }
	
	[JsonIgnore]
	public Proxy Proxy { get; init; } = null!;
	
	public uint Uid { get; init; }
	
	readonly int _level;
	
	public required Agents Id { get; init; }

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
			_ => AscensionState.A0_10
		};
	}

	public AscensionState Ascension { get; init; }

	public int Cinema { get; init; }

	public Weapon? Engine { get; init; }

	[MaxLength(30)]
	public required string Name { get; init; }

	public class Weapon {
		public uint Uid { get; init; }
		
		readonly int _level;
		
		public Engines Id { get; init; }

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

		public int Refinement { get; init; } = 1;
		
		[MaxLength(30)]
		public required string Name { get; init; }
		
		public AscensionState Ascension { get; set; }
	}

	public required List<Skill> Skills { get; init; }

	public class Skill {

		public uint Uid { get; init; }
		
		public Skills Id { get; init; }

		public int Level { get; init; }
		
		public string Title { get; init; } = "Unknown";
	}

	public required List<Disc> Discs { get; init; }

	public class Disc {
		public uint Uid { get; init; }
		
		public required Discs Id { get; init; }

		public required int Level { get; init; }

		[MaxLength(30)]
		public string Name { get; init; } = "Unknown";

		public required ItemRank Rank { get; init; }

		public required int Slot { get; init; }

		public required Stat? MainStat { get; init; }

		public required List<Stat> SubStats { get; init; }

		public class Stat {
			
			public uint Uid { get; init; }
			
			public required DiscStats Id { get; init; }
			
			[MaxLength(30)]
			public string Name { get; init; } = "Unknown";

			public required string Value { get; init; }

			public int Rolls { get; init; } = -1;
		}
	}
}