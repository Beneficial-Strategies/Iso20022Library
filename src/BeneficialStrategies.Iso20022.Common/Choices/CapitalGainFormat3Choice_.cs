// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of capital gain.
    /// </summary>
    [KnownType(typeof(CapitalGainFormat3Choice.Code))]
    [KnownType(typeof(CapitalGainFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(CapitalGainFormat3Choice.Code), nameof(CapitalGainFormat3Choice.Code))]
    [JsonDerivedType(
        typeof(CapitalGainFormat3Choice.Proprietary),
        nameof(CapitalGainFormat3Choice.Proprietary)
    )]
    [IsoId("_MYGIUUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Capital Gain Format 3 Choice")]
    public abstract record CapitalGainFormat3Choice_ { }
}
