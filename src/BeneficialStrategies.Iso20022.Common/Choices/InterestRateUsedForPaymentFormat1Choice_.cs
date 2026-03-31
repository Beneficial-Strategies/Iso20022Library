// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat1Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat1Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat1Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat1Choice.Rate),
        nameof(InterestRateUsedForPaymentFormat1Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat1Choice.Amount),
        nameof(InterestRateUsedForPaymentFormat1Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat1Choice.RateTypeAndAmountAndRateStatus),
        nameof(InterestRateUsedForPaymentFormat1Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat1Choice.NotSpecifiedRate),
        nameof(InterestRateUsedForPaymentFormat1Choice.NotSpecifiedRate)
    )]
    [IsoId("_UOySodp-Ed-ak6NoX_4Aeg_-1208255480")]
    [DisplayName("Interest Rate Used For Payment Format 1 Choice")]
    public abstract record InterestRateUsedForPaymentFormat1Choice_ { }
}
