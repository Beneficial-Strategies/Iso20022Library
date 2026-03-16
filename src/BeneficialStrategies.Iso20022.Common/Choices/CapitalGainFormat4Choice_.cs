// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of capital gain.
    /// </summary>
    [KnownType(typeof(CapitalGainFormat4Choice.Code))]
    [KnownType(typeof(CapitalGainFormat4Choice.Proprietary))]
    [JsonDerivedType(typeof(CapitalGainFormat4Choice.Code), nameof(CapitalGainFormat4Choice.Code))]
    [JsonDerivedType(
        typeof(CapitalGainFormat4Choice.Proprietary),
        nameof(CapitalGainFormat4Choice.Proprietary)
    )]
    [IsoId("_c5V6p5KQEeWHWpTQn1FFVg")]
    [DisplayName("Capital Gain Format 4 Choice")]
    public abstract record CapitalGainFormat4Choice_ { }
}
