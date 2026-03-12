// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat10Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat10Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat10Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat10Choice.Rate),nameof(InterestRateUsedForPaymentFormat10Choice.Rate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat10Choice.Amount),nameof(InterestRateUsedForPaymentFormat10Choice.Amount))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat10Choice.RateTypeAndAmountAndRateStatus),nameof(InterestRateUsedForPaymentFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat10Choice.NotSpecifiedRate),nameof(InterestRateUsedForPaymentFormat10Choice.NotSpecifiedRate))]
    [IsoId("_cteBw5KQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Rate Used For Payment Format 10 Choice")]
    public abstract partial record InterestRateUsedForPaymentFormat10Choice_
    {
    }
}
