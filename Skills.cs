namespace ZZZ.ApiModels;

/// <summary>
/// Available skills in the game.
/// </summary>

public enum Skills
{
	/*
	 * Alternative version of skills.
	 * Not returned by the api but used in the calculator client.
	 */
	Ex = -50,
	Dash,
	Ultimate,
	Additional,
	Quick,
	
	Anomaly = -10,
	Disorder,
	
	/*
	 * Skills returned by the api.
	 */
	Basic = 0,
	Special,
	Dodge,
	Chain,
	Core = 5,
	Assist,
}