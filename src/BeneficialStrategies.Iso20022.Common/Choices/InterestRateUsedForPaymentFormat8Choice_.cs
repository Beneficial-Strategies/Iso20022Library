// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat8Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat8Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat8Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat8Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat8Choice.Rate),
        nameof(InterestRateUsedForPaymentFormat8Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat8Choice.Amount),
        nameof(InterestRateUsedForPaymentFormat8Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat8Choice.RateTypeAndAmountAndRateStatus),
        nameof(InterestRateUsedForPaymentFormat8Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat8Choice.NotSpecifiedRate),
        nameof(InterestRateUsedForPaymentFormat8Choice.NotSpecifiedRate)
    )]
    [IsoId("_WG3o2UEIEeWVgfuHGaKtRQ")]
    [DisplayName("Interest Rate Used For Payment Format 8 Choice")]
    public abstract record InterestRateUsedForPaymentFormat8Choice_ { }
}
