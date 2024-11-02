// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace ZZZ.ApiModels.Responses;

public class Agent {

	public int Id { get; init; }

	public int Level { get; init; }

	public int Cinema { get; init; }

	public Weapon? Engine { get; init; }

	public required string Name { get; init; }

	public class Weapon {
		
		public Engines Id { get; init; }
		
		public int Level { get; init; }

		public int Refinement { get; init; }

		public required string Name { get; init; }
	}

	public required Mindscape[] Cinemas { get; init; }
	
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
		}
	}
}