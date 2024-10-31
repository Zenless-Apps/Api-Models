namespace ZZZ.ApiModels.Extensions;

using System.ComponentModel;
using System.Reflection;

public static class EnumExtensions {
	public static string ToApiString<T>(this T value) where T : Enum {
		var type = typeof(T);
		
		var fieldInfo = type.GetField(value.ToString());
		
		var descriptionAttribute = fieldInfo!.GetCustomAttribute<DescriptionAttribute>();
		
		return descriptionAttribute?.Description ?? value.ToString();
	}
}