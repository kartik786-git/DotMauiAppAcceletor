﻿using CommunityToolkit.Maui.Converters;

namespace DotMauiAppAcceletor.Converters;

public class WebNavigatedEventArgsConverter : BaseConverterOneWay<WebNavigatedEventArgs, object>
{
	public override object DefaultConvertReturnValue { get; set; }

	public override object ConvertFrom(WebNavigatedEventArgs value, CultureInfo culture = null) => value switch
	{
		null => null,
		_ => value
	};
}
