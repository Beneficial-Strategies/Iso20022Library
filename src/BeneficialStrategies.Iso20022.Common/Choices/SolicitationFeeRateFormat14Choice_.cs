// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Solicitation Fee Rate Format14Choice.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat14Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat14Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat14Choice.NotSpecifiedRate))]
    [KnownType(typeof(SolicitationFeeRateFormat14Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat14Choice.Amount),nameof(SolicitationFeeRateFormat14Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat14Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat14Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat14Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat14Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat14Choice.Rate),nameof(SolicitationFeeRateFormat14Choice.Rate))]
    [IsoId("_l6ZcOJt3Ee-wQIOX0djF2w")]
    [DisplayName("Solicitation Fee Rate Format14Choice")]
    public abstract partial record SolicitationFeeRateFormat14Choice_
    {
    }
}
