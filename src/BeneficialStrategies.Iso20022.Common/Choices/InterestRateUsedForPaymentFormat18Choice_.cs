// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Interest Rate Used For Payment Format18Choice.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat18Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat18Choice.NotSpecifiedRate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat18Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat18Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat18Choice.Amount),nameof(InterestRateUsedForPaymentFormat18Choice.Amount))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat18Choice.NotSpecifiedRate),nameof(InterestRateUsedForPaymentFormat18Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat18Choice.Rate),nameof(InterestRateUsedForPaymentFormat18Choice.Rate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat18Choice.RateTypeAndAmountAndRateStatus),nameof(InterestRateUsedForPaymentFormat18Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_esApkaEPEe-4O7NbwmwJkQ")]
    [DisplayName("Interest Rate Used For Payment Format18Choice")]
    public abstract partial record InterestRateUsedForPaymentFormat18Choice_
    {
    }
}
