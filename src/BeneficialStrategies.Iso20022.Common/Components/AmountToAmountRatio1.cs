// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as a quotient of amounts.
/// </summary>
[IsoId("_UHySwNp-Ed-ak6NoX_4Aeg_579173663")]
[DisplayName("Amount To Amount Ratio")]
public record AmountToAmountRatio1
{
    /// <summary>
    /// Numerator of the quotient of amounts.
    /// </summary>
    [IsoId("_UHySwdp-Ed-ak6NoX_4Aeg_622579243")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt1")]
    public required ActiveCurrencyAndAmount Amount1 { get; init; }

    /// <summary>
    /// Denominator of the quotient of amounts.
    /// </summary>
    [IsoId("_UHySwtp-Ed-ak6NoX_4Aeg_636432914")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt2")]
    public required ActiveCurrencyAndAmount Amount2 { get; init; }
}
