// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(TaxCreditRateFormat1Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat1Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(TaxCreditRateFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat1Choice.Rate),nameof(TaxCreditRateFormat1Choice.Rate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat1Choice.Amount),nameof(TaxCreditRateFormat1Choice.Amount))]
    [JsonDerivedType(typeof(TaxCreditRateFormat1Choice.RateTypeAndAmountAndRateStatus),nameof(TaxCreditRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(TaxCreditRateFormat1Choice.NotSpecifiedRate),nameof(TaxCreditRateFormat1Choice.NotSpecifiedRate))]
    [IsoId("_UOVmvNp-Ed-ak6NoX_4Aeg_465502986")]
    [DisplayName("Tax Credit Rate Format 1 Choice")]
    public abstract partial record TaxCreditRateFormat1Choice_
    {
    }
}
