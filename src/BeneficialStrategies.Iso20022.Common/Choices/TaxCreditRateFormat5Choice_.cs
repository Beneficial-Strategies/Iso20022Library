// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(TaxCreditRateFormat5Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat5Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(TaxCreditRateFormat5Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat5Choice.Rate),nameof(TaxCreditRateFormat5Choice.Rate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat5Choice.Amount),nameof(TaxCreditRateFormat5Choice.Amount))]
    [JsonDerivedType(typeof(TaxCreditRateFormat5Choice.RateTypeAndAmountAndRateStatus),nameof(TaxCreditRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(TaxCreditRateFormat5Choice.NotSpecifiedRate),nameof(TaxCreditRateFormat5Choice.NotSpecifiedRate))]
    [IsoId("_DeFVIOwPEd-sn-FiNtktcA")]
    [DisplayName("Tax Credit Rate Format 5 Choice")]
    public abstract partial record TaxCreditRateFormat5Choice_
    {
    }
}
