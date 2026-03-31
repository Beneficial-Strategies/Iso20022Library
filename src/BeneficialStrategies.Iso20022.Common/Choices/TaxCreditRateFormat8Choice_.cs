// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(TaxCreditRateFormat8Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat8Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat8Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(TaxCreditRateFormat8Choice.NotSpecifiedRate))]
    [JsonDerivedType(
        typeof(TaxCreditRateFormat8Choice.Rate),
        nameof(TaxCreditRateFormat8Choice.Rate)
    )]
    [JsonDerivedType(
        typeof(TaxCreditRateFormat8Choice.Amount),
        nameof(TaxCreditRateFormat8Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(TaxCreditRateFormat8Choice.RateTypeAndAmountAndRateStatus),
        nameof(TaxCreditRateFormat8Choice.RateTypeAndAmountAndRateStatus)
    )]
    [JsonDerivedType(
        typeof(TaxCreditRateFormat8Choice.NotSpecifiedRate),
        nameof(TaxCreditRateFormat8Choice.NotSpecifiedRate)
    )]
    [IsoId("_W5KBb0EIEeWVgfuHGaKtRQ")]
    [DisplayName("Tax Credit Rate Format 8 Choice")]
    public abstract record TaxCreditRateFormat8Choice_ { }
}
