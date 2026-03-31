// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the tracking information.
    /// </summary>
    [KnownType(typeof(Tracking3Choice.Indicator))]
    [KnownType(typeof(Tracking3Choice.Proprietary))]
    [JsonDerivedType(typeof(Tracking3Choice.Indicator), nameof(Tracking3Choice.Indicator))]
    [JsonDerivedType(typeof(Tracking3Choice.Proprietary), nameof(Tracking3Choice.Proprietary))]
    [IsoId("_AZHgEdokEeC60axPepSq7g_546870439")]
    [DisplayName("Tracking 3 Choice")]
    public abstract record Tracking3Choice_ { }
}
