﻿namespace Serilog.Settings.Configuration;

interface IConfigurationArgumentValue
{
    object ConvertTo(Type toType, ResolutionContext resolutionContext);
}
