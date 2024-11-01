namespace ZZZ.ApiModels.Responses;

public class Agent {

	public int Id { get; set; }

	public int Level { get; set; }

	public int Cinema { get; set; }

	public Weapon? Engine { get; set; }

	public required string Name { get; set; }

	public class Weapon {
		
		public int Id { get; set; }
		
		public int Level { get; set; }

		public int Refinement { get; set; }

		public required string Name { get; set; }
	}

	public required Mindscape[] Cinemas { get; set; }
	
	public class Mindscape {
		
		public int Id { get; set; }
		
		public int Pos { get; set; }

		public bool Unlocked { get; set; }
	}
	
	public required Skill[] Skills { get; set; }
	
	public class Skill {
		
		public int Id { get; set; }
		
		public int Level { get; set; }
	}
	
	public required Disc[] Discs { get; set; }
	
	public class Disc {
		
		public Discs Id { get; set; }
		
		public int Level { get; set; }
		
		public required string Name { get; set; }
		
		public required ItemRank Rank { get; set; }
		
		public int Slot { get; set; }
		
		public required Stat MainStat { get; set; }
		
		public required Stat[] SubStats { get; set; }
		
		public class Stat {
			public DiscStats Id { get; set; }
			public required string Name { get; set; }
			public required string Value { get; set; }
		}
	}
}