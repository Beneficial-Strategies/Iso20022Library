// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat3Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat3Choice.NotSpecifiedRate))]
    [KnownType(typeof(SolicitationFeeRateFormat3Choice.AmountToQuantity))]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat3Choice.Rate),
        nameof(SolicitationFeeRateFormat3Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat3Choice.NotSpecifiedRate),
        nameof(SolicitationFeeRateFormat3Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat3Choice.AmountToQuantity),
        nameof(SolicitationFeeRateFormat3Choice.AmountToQuantity)
    )]
    [IsoId("_3xdV8OwOEd-sn-FiNtktcA")]
    [DisplayName("Solicitation Fee Rate Format 3 Choice")]
    public abstract record SolicitationFeeRateFormat3Choice_ { }
}
