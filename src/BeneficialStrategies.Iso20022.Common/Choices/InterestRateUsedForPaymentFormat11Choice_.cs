// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Interest Rate Used For Payment Format11Choice.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat11Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat11Choice.NotSpecifiedRate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat11Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat11Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat11Choice.Amount),nameof(InterestRateUsedForPaymentFormat11Choice.Amount))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat11Choice.NotSpecifiedRate),nameof(InterestRateUsedForPaymentFormat11Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat11Choice.Rate),nameof(InterestRateUsedForPaymentFormat11Choice.Rate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat11Choice.RateTypeAndAmountAndRateStatus),nameof(InterestRateUsedForPaymentFormat11Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_N9He4YV6Ee-oeNhl-Tk6YQ")]
    [DisplayName("Interest Rate Used For Payment Format11Choice")]
    public abstract partial record InterestRateUsedForPaymentFormat11Choice_
    {
    }
}
