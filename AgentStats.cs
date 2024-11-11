namespace ZZZ.ApiModels;

/// <summary>
/// Stats that a disc or engine can have either as main stat or sub stat.
/// </summary>
public enum AgentStats {
	HpPercent = 11102,
	Hp = 11103,
	/// <summary>
	/// Used only for weapons as main stat.
	/// </summary>
	BaseAtk = 12101,
	AtkPercent = 12102,
	Atk = 12103,
	Impact = 12202,
	DefPercent = 13102,
	Def = 13103,
	CritRate = 20103,
	CritDmg = 21103,
	PenRatio = 23103,
	Pen = 23203,
	AnomalyProficiency = 31203,
	AnomalyMastery = 31402,
	EnergyRegen = 30502,
	PhysicalDmg = 31503,
	FireDmg = 31603,
	IceDmg = 31703,
	ElectricDmg = 31803,
	EtherDmg = 31903,
}