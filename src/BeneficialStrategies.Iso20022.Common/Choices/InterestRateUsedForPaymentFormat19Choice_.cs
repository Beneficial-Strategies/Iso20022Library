// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Interest Rate Used For Payment Format19Choice.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat19Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat19Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat19Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat19Choice.Amount),nameof(InterestRateUsedForPaymentFormat19Choice.Amount))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat19Choice.Rate),nameof(InterestRateUsedForPaymentFormat19Choice.Rate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat19Choice.RateTypeAndAmountAndRateStatus),nameof(InterestRateUsedForPaymentFormat19Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_IGIfEaGiEe-4O7NbwmwJkQ")]
    [DisplayName("Interest Rate Used For Payment Format19Choice")]
    public abstract partial record InterestRateUsedForPaymentFormat19Choice_
    {
    }
}
