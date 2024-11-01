namespace ZZZ.ApiModels;

/// <summary>
/// There are some codes that are returned by the API.
///
/// Is possible that the API returns a code that is not listed here, these are the most common codes.
/// </summary>
public enum ApiCode {
	Ok = 0,
	Error = 1,
	UidNotFound = -500001,
	PrivateProfile = -501000,
	HoyolabError = -1023
}