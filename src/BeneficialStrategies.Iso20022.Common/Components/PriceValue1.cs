// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value given to a price.
/// </summary>
[IsoId("_QaaCEtp-Ed-ak6NoX_4Aeg_-423063067")]
[DisplayName("Price Value")]
public record PriceValue1
{
    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_QaaCE9p-Ed-ak6NoX_4Aeg_585422220")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAnd13DecimalAmount Amount { get; init; }
}
