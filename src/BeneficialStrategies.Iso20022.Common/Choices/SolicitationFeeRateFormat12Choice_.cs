// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Solicitation Fee Rate Format12Choice.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat12Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat12Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat12Choice.Rate))]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat12Choice.Amount),
        nameof(SolicitationFeeRateFormat12Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat12Choice.AmountToQuantity),
        nameof(SolicitationFeeRateFormat12Choice.AmountToQuantity)
    )]
    [JsonDerivedType(
        typeof(SolicitationFeeRateFormat12Choice.Rate),
        nameof(SolicitationFeeRateFormat12Choice.Rate)
    )]
    [IsoId("_OIfroYV-Ee-ufOxNNkEXmg")]
    [DisplayName("Solicitation Fee Rate Format12Choice")]
    public abstract record SolicitationFeeRateFormat12Choice_ { }
}
