// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace ZZZ.ApiModels.Responses;

using System.Text.Json.Serialization;

public class Agent {
	readonly int _level;

	public Agents Id { get; init; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public int Level
	{
		get => _level;
		init
		{
			_level = value;
			Ascension = A(_level);
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

	public required string Name { get; init; }

	public class Weapon {
		readonly int _level;
		
		public Engines Id { get; init; }

		[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public int Level
		{
			get => _level;
			init
			{
				_level = value;
				Ascension = A(_level);
			}
		}


		public int Refinement { get; init; }

		public required string Name { get; init; }

		public AscensionState Ascension { get; set; }
	}

	[Obsolete("Use Cinema instead")]
	public Mindscape[] Cinemas { get; init; } = [];

	[Obsolete("This class is redundant, use Cinema instead")]
	public class Mindscape {

		public int Id { get; init; }

		public int Pos { get; init; }

		public bool Unlocked { get; init; }
	}

	public required Skill[] Skills { get; init; }

	public class Skill {

		public Skills Id { get; init; }

		public int Level { get; init; }

		public required string Title { get; init; }
	}

	public required Disc[] Discs { get; init; }

	public class Disc {

		public Discs Id { get; init; }

		public int Level { get; init; }

		public required string Name { get; init; }

		public required ItemRank Rank { get; init; }

		public int Slot { get; init; }

		public required Stat? MainStat { get; init; }

		public required Stat[] SubStats { get; init; }

		public class Stat {
			public DiscStats Id { get; init; }

			public required string Name { get; init; }

			public required string Value { get; init; }

			public int Rolls { get; init; } = -1;
		}
	}
}