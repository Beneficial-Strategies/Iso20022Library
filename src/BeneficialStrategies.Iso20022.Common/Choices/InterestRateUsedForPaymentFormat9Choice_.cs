// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat9Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat9Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat9Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat9Choice.Rate),
        nameof(InterestRateUsedForPaymentFormat9Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat9Choice.Amount),
        nameof(InterestRateUsedForPaymentFormat9Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat9Choice.RateTypeAndAmountAndRateStatus),
        nameof(InterestRateUsedForPaymentFormat9Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_cj-G-ZKQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Rate Used For Payment Format 9 Choice")]
    public abstract record InterestRateUsedForPaymentFormat9Choice_ { }
}
