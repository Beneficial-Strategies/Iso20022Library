// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Interest Rate Used For Payment Format12Choice.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat12Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat12Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat12Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat12Choice.Amount),nameof(InterestRateUsedForPaymentFormat12Choice.Amount))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat12Choice.Rate),nameof(InterestRateUsedForPaymentFormat12Choice.Rate))]
    [JsonDerivedType(typeof(InterestRateUsedForPaymentFormat12Choice.RateTypeAndAmountAndRateStatus),nameof(InterestRateUsedForPaymentFormat12Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_ER1IgYV-Ee-ufOxNNkEXmg")]
    [DisplayName("Interest Rate Used For Payment Format12Choice")]
    public abstract partial record InterestRateUsedForPaymentFormat12Choice_
    {
    }
}
