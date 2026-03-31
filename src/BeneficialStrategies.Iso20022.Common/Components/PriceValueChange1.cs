// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Value given to a positive or negative price change.
/// </summary>
[IsoId("_QajzFNp-Ed-ak6NoX_4Aeg_-1357819098")]
[DisplayName("Price Value Change")]
public record PriceValueChange1
{
    /// <summary>
    /// Amount by which the price has changed.
    /// </summary>
    [IsoId("_QajzFdp-Ed-ak6NoX_4Aeg_-1357819072")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; }

    /// <summary>
    /// Indicates a positive or negative amount change.
    /// </summary>
    [IsoId("_QajzFtp-Ed-ak6NoX_4Aeg_-1314414014")]
    [DisplayName("Amount Sign")]
    [IsoXmlTag("AmtSgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? AmountSign { get; init; }

    /// <summary>
    /// Rate by which the price has changed.
    /// </summary>
    [IsoId("_QajzF9p-Ed-ak6NoX_4Aeg_-1357819056")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }
}
