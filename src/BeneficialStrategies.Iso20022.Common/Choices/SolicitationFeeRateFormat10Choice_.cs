// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.AmountToQuantity))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.Amount))]
    [KnownType(typeof(SolicitationFeeRateFormat10Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat10Choice.Rate),nameof(SolicitationFeeRateFormat10Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat10Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat10Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat10Choice.Amount),nameof(SolicitationFeeRateFormat10Choice.Amount))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat10Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat10Choice.NotSpecifiedRate))]
    [IsoId("_ctoZN5KQEeWHWpTQn1FFVg")]
    [DisplayName("Solicitation Fee Rate Format 10 Choice")]
    public abstract partial record SolicitationFeeRateFormat10Choice_
    {
    }
}
