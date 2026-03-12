// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the tracking information.
    /// </summary>
    [KnownType(typeof(Tracking4Choice.Indicator))]
    [KnownType(typeof(Tracking4Choice.Proprietary))]
    [JsonDerivedType(typeof(Tracking4Choice.Indicator),nameof(Tracking4Choice.Indicator))]
    [JsonDerivedType(typeof(Tracking4Choice.Proprietary),nameof(Tracking4Choice.Proprietary))]
    [IsoId("_YKnvgTtFEeWRTLSN0i0tng")]
    [DisplayName("Tracking 4 Choice")]
    public abstract partial record Tracking4Choice_
    {
    }
}
