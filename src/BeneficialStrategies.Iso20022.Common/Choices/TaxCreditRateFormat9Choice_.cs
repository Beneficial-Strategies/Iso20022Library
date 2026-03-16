// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(TaxCreditRateFormat9Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat9Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat9Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(
        typeof(TaxCreditRateFormat9Choice.Rate),
        nameof(TaxCreditRateFormat9Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(TaxCreditRateFormat9Choice.Amount),
        nameof(TaxCreditRateFormat9Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(TaxCreditRateFormat9Choice.RateTypeAndAmountAndRateStatus),
        nameof(TaxCreditRateFormat9Choice.RateTypeAndAmountAndRateStatus)
    )]
    [IsoId("_ckCYvpKQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Credit Rate Format 9 Choice")]
    public abstract record TaxCreditRateFormat9Choice_ { }
}
