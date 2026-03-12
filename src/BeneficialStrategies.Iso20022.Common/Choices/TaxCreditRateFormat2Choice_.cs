// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(TaxCreditRateFormat2Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat2Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(TaxCreditRateFormat2Choice.Rate),nameof(TaxCreditRateFormat2Choice.Rate))]
    [JsonDerivedType(typeof(TaxCreditRateFormat2Choice.Amount),nameof(TaxCreditRateFormat2Choice.Amount))]
    [JsonDerivedType(typeof(TaxCreditRateFormat2Choice.RateTypeAndAmountAndRateStatus),nameof(TaxCreditRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_UMtPDtp-Ed-ak6NoX_4Aeg_-1830345508")]
    [DisplayName("Tax Credit Rate Format 2 Choice")]
    public abstract partial record TaxCreditRateFormat2Choice_
    {
    }
}
