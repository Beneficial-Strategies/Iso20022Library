// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Solicitation Fee Rate Format15Choice.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat15Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat15Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat15Choice.NotSpecifiedRate))]
    [KnownType(typeof(SolicitationFeeRateFormat15Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat15Choice.Amount),nameof(SolicitationFeeRateFormat15Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat15Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat15Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat15Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat15Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat15Choice.Rate),nameof(SolicitationFeeRateFormat15Choice.Rate))]
    [IsoId("_nLnyc5t3Ee-wQIOX0djF2w")]
    [DisplayName("Solicitation Fee Rate Format15Choice")]
    public abstract partial record SolicitationFeeRateFormat15Choice_
    {
    }
}
