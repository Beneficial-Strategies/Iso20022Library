// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat7Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat7Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat7Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat7Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat7Choice.Rate),nameof(SolicitationFeeRateFormat7Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat7Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat7Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat7Choice.Amount),nameof(SolicitationFeeRateFormat7Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat7Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat7Choice.NotSpecifiedRate))]
    [IsoId("_7y0l9UEKEeWVgfuHGaKtRQ")]
    [DisplayName("Solicitation Fee Rate Format 7 Choice")]
    public abstract partial record SolicitationFeeRateFormat7Choice_
    {
    }
}
