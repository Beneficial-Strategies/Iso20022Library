// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Solicitation Fee Rate Format11Choice.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat11Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat11Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat11Choice.NotSpecifiedRate))]
    [KnownType(typeof(SolicitationFeeRateFormat11Choice.Rate))]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat11Choice.Amount),
        nameof(SolicitationFeeRateFormat11Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat11Choice.AmountToQuantity),
        nameof(SolicitationFeeRateFormat11Choice.AmountToQuantity)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat11Choice.NotSpecifiedRate),
        nameof(SolicitationFeeRateFormat11Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat11Choice.Rate),
        nameof(SolicitationFeeRateFormat11Choice.Rate)
    )]
    [IsoId("_DIiFgYV7Ee-oeNhl-Tk6YQ")]
    [DisplayName("Solicitation Fee Rate Format11Choice")]
    public abstract record SolicitationFeeRateFormat11Choice_ { }
}
