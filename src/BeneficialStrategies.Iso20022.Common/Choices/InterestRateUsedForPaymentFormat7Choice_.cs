// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat7Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat7Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat7Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat7Choice.Rate),
        nameof(InterestRateUsedForPaymentFormat7Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat7Choice.Amount),
        nameof(InterestRateUsedForPaymentFormat7Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat7Choice.RateTypeAndAmountAndRateStatus),
        nameof(InterestRateUsedForPaymentFormat7Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_VJurJ0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Interest Rate Used For Payment Format 7 Choice")]
    public abstract record InterestRateUsedForPaymentFormat7Choice_ { }
}
