// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat5Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat5Choice.Rate),nameof(SolicitationFeeRateFormat5Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat5Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat5Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat5Choice.Amount),nameof(SolicitationFeeRateFormat5Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat5Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat5Choice.NotSpecifiedRate))]
    [IsoId("_REpUgRLsEeKJ5uSjVyVvug")]
    [DisplayName("Solicitation Fee Rate Format 5 Choice")]
    public abstract partial record SolicitationFeeRateFormat5Choice_
    {
    }
}
