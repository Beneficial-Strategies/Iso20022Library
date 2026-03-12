// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(SolicitationFeeRateFormat1Choice.Rate))]
    [KnownType(typeof(SolicitationFeeRateFormat1Choice.NotSpecifiedRate))]
    [KnownType(typeof(SolicitationFeeRateFormat1Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat1Choice.Rate),nameof(SolicitationFeeRateFormat1Choice.Rate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat1Choice.NotSpecifiedRate),nameof(SolicitationFeeRateFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(SolicitationFeeRateFormat1Choice.AmountToQuantity),nameof(SolicitationFeeRateFormat1Choice.AmountToQuantity))]
    [IsoId("_UOMcx9p-Ed-ak6NoX_4Aeg_-903069211")]
    [DisplayName("Solicitation Fee Rate Format 1 Choice")]
    public abstract partial record SolicitationFeeRateFormat1Choice_
    {
    }
}
