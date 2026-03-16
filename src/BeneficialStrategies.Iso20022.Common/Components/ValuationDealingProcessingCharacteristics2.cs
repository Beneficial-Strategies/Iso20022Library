// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation dealing processing characteristics linked to the instrument, ie, not to the market.
/// </summary>
[IsoId("_UBOXydp-Ed-ak6NoX_4Aeg_689275880")]
[DisplayName("Valuation Dealing Processing Characteristics")]
public record ValuationDealingProcessingCharacteristics2
{
    /// <summary>
    /// Frequency of the valuation.
    /// </summary>
    [IsoId("_UBOXytp-Ed-ak6NoX_4Aeg_689276311")]
    [DisplayName("Valuation Frequency")]
    [IsoXmlTag("ValtnFrqcy")]
    public required EventFrequency5Code ValuationFrequency { get; init; }

    /// <summary>
    /// Further details regarding the dealing frequency, eg, Tuesday (for weekly dealing) or last business day of the month.
    /// </summary>
    [IsoId("_UBOXy9p-Ed-ak6NoX_4Aeg_689276342")]
    [DisplayName("Valuation Frequency Description")]
    [IsoXmlTag("ValtnFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text ValuationFrequencyDescription { get; init; }

    /// <summary>
    /// Number of decimal places to which quantities of units/shares are rounded.
    /// </summary>
    [IsoId("_UBYIwNp-Ed-ak6NoX_4Aeg_690196799")]
    [DisplayName("Decimalisation Units")]
    [IsoXmlTag("DcmlstnUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber DecimalisationUnits { get; init; }

    /// <summary>
    /// Number of decimal places to which quantities of units/shares are rounded.
    /// </summary>
    [IsoId("_UBYIwdp-Ed-ak6NoX_4Aeg_689276796")]
    [DisplayName("Decimalisation Price")]
    [IsoXmlTag("DcmlstnPric")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber DecimalisationPrice { get; init; }

    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("_UBYIwtp-Ed-ak6NoX_4Aeg_689276681")]
    [DisplayName("Dual Fund Indicator")]
    [IsoXmlTag("DualFndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator DualFundIndicator { get; init; }

    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_UBYIw9p-Ed-ak6NoX_4Aeg_689276712")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public required PriceMethod1Code PriceMethod { get; init; }

    /// <summary>
    /// Currencies in which the prices for the investment fund class are published by the fund management company.
    /// </summary>
    [IsoId("_UBYIxNp-Ed-ak6NoX_4Aeg_689276743")]
    [DisplayName("Price Currency")]
    [IsoXmlTag("PricCcy")]
    public SimpleValueList<string> PriceCurrency { get; init; } = [];
    // ID for the above is _UBYIxNp-Ed-ak6NoX_4Aeg_689276743
}
