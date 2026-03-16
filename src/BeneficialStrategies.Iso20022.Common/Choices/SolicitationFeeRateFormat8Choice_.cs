// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat8Choice.Amount))]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat8Choice.Rate),
        nameof(SolicitationFeeRateFormat8Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat8Choice.AmountToQuantity),
        nameof(SolicitationFeeRateFormat8Choice.AmountToQuantity)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat8Choice.Amount),
        nameof(SolicitationFeeRateFormat8Choice.Amount)
    )]
    [IsoId("_NlMNz2NZEeW4z96Yfj3Wng")]
    [DisplayName("Solicitation Fee Rate Format 8 Choice")]
    public abstract record SolicitationFeeRateFormat8Choice_ { }
}
