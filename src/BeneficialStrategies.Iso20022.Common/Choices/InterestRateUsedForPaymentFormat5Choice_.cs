// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat5Choice.Rate),
        nameof(InterestRateUsedForPaymentFormat5Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat5Choice.Amount),
        nameof(InterestRateUsedForPaymentFormat5Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus),
        nameof(InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate),
        nameof(InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate)
    )]
    [IsoId("_iS_3geEREd-1Ktb5rVaajw")]
    [DisplayName("Interest Rate Used For Payment Format 5 Choice")]
    public abstract record InterestRateUsedForPaymentFormat5Choice_ { }
}
