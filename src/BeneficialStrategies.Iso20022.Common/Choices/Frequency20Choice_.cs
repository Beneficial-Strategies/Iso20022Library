// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the frequency.
    /// </summary>
    [KnownType(typeof(Frequency20Choice.Code))]
    [KnownType(typeof(Frequency20Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency20Choice.Code), nameof(Frequency20Choice.Code))]
    [JsonDerivedType(typeof(Frequency20Choice.Proprietary), nameof(Frequency20Choice.Proprietary))]
    [IsoId("_B_wykRUSEeOIaq8KyCdIDQ")]
    [DisplayName("Frequency 20 Choice")]
    public abstract record Frequency20Choice_ { }
}
