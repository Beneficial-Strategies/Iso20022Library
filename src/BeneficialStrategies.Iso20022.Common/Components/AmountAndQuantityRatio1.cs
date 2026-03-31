// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as amount per quantity.
/// </summary>
[IsoId("_UH8Dxtp-Ed-ak6NoX_4Aeg_1587658520")]
[DisplayName("Amount And Quantity Ratio")]
public record AmountAndQuantityRatio1
{
    /// <summary>
    /// Cash amount.
    /// </summary>
    [IsoId("_UH8Dx9p-Ed-ak6NoX_4Aeg_1626446913")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Quantity expressed as number.
    /// </summary>
    [IsoId("_UH8DyNp-Ed-ak6NoX_4Aeg_1641222331")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber Quantity { get; init; }
}
