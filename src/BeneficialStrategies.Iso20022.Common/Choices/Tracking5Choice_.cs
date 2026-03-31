// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the tracking information.
    /// </summary>
    [KnownType(typeof(Tracking5Choice.Indicator))]
    [KnownType(typeof(Tracking5Choice.Proprietary))]
    [JsonDerivedType(typeof(Tracking5Choice.Indicator), nameof(Tracking5Choice.Indicator))]
    [JsonDerivedType(typeof(Tracking5Choice.Proprietary), nameof(Tracking5Choice.Proprietary))]
    [IsoId("_5xrt85NLEeWGlc8L7oPDIg")]
    [DisplayName("Tracking 5 Choice")]
    public abstract record Tracking5Choice_ { }
}
