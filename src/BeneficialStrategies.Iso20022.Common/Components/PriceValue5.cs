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
[IsoId("_QajzEtp-Ed-ak6NoX_4Aeg_892189761")]
[DisplayName("Price Value")]
public record PriceValue5
{
    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_QajzE9p-Ed-ak6NoX_4Aeg_903272045")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAnd13DecimalAmount Amount { get; init; }
}
