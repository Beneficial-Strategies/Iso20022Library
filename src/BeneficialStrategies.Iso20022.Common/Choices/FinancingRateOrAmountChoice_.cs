// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between amount expressed as an absolute value or as a percentage rate related to another reference amount.
    /// </summary>
    [KnownType(typeof(FinancingRateOrAmountChoice.Amount))]
    [KnownType(typeof(FinancingRateOrAmountChoice.Rate))]
    [JsonDerivedType(
        typeof(FinancingRateOrAmountChoice.Amount),
        nameof(FinancingRateOrAmountChoice.Amount)
    )]
    [JsonDerivedType(
        typeof(FinancingRateOrAmountChoice.Rate),
        nameof(FinancingRateOrAmountChoice.Rate)
    )]
    [IsoId("_RXzecNp-Ed-ak6NoX_4Aeg_-2069508751")]
    [DisplayName("Financing Rate Or Amount Choice")]
    public abstract record FinancingRateOrAmountChoice_ { }
}
