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
	Ex = -5,
	Dash,
	Chain,
	Additional,
	Quick,
	
	/*
	 * Skills returned by the api.
	 */
	Basic = 0,
	Special,
	Dodge,
	Ultimate,
	Core = 5,
	Assist,
}