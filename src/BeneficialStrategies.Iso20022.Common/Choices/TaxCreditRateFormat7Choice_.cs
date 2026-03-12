// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(TaxCreditRateFormat7Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat7Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat7Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(TaxCreditRateFormat7Choice.Rate),nameof(TaxCreditRateFormat7Choice.Rate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat7Choice.Amount),nameof(TaxCreditRateFormat7Choice.Amount))]
    [JsonDerivedType(typeof(TaxCreditRateFormat7Choice.RateTypeAndAmountAndRateStatus),nameof(TaxCreditRateFormat7Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_WTXz5UEIEeWVgfuHGaKtRQ")]
    [DisplayName("Tax Credit Rate Format 7 Choice")]
    public abstract partial record TaxCreditRateFormat7Choice_
    {
    }
}
