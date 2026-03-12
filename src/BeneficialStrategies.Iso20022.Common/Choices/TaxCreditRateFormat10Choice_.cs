// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(TaxCreditRateFormat10Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat10Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(TaxCreditRateFormat10Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat10Choice.Rate),nameof(TaxCreditRateFormat10Choice.Rate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat10Choice.Amount),nameof(TaxCreditRateFormat10Choice.Amount))]
    [JsonDerivedType(typeof(TaxCreditRateFormat10Choice.RateTypeAndAmountAndRateStatus),nameof(TaxCreditRateFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(TaxCreditRateFormat10Choice.NotSpecifiedRate),nameof(TaxCreditRateFormat10Choice.NotSpecifiedRate))]
    [IsoId("_ctjhL5KQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Credit Rate Format 10 Choice")]
    public abstract partial record TaxCreditRateFormat10Choice_
    {
    }
}
