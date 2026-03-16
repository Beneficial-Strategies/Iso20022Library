// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat2Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat2Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat2Choice.Rate),
        nameof(InterestRateUsedForPaymentFormat2Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat2Choice.Amount),
        nameof(InterestRateUsedForPaymentFormat2Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(InterestRateUsedForPaymentFormat2Choice.RateTypeAndAmountAndRateStatus),
        nameof(InterestRateUsedForPaymentFormat2Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_UM2Y_Np-Ed-ak6NoX_4Aeg_-807410440")]
    [DisplayName("Interest Rate Used For Payment Format 2 Choice")]
    public abstract record InterestRateUsedForPaymentFormat2Choice_ { }
}
