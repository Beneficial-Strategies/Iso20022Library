// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation dealing processing characteristics linked to the instrument, that is, not to the market.
/// </summary>
[IsoId("_DovC8UlNEeiZP-CimVE7Hg")]
[DisplayName("Valuation Dealing Processing Characteristics")]
public record ValuationDealingProcessingCharacteristics3
{
    /// <summary>
    /// Frequency of the valuation.
    /// </summary>
    [IsoId("_D4puQ0lNEeiZP-CimVE7Hg")]
    [DisplayName("Valuation Frequency")]
    [IsoXmlTag("ValtnFrqcy")]
    public EventFrequency5Code? ValuationFrequency { get; init; }

    /// <summary>
    /// Further details regarding the dealing frequency, for example, Tuesday (for weekly dealing) or last business day of the month.
    /// </summary>
    [IsoId("_D4puRUlNEeiZP-CimVE7Hg")]
    [DisplayName("Valuation Frequency Description")]
    [IsoXmlTag("ValtnFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? ValuationFrequencyDescription { get; init; }

    /// <summary>
    /// Valuation time of the fund.
    /// </summary>
    [IsoId("_lx4-wF80Eeicg40_9gK9vQ")]
    [DisplayName("Valuation Time")]
    [IsoXmlTag("ValtnTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ValuationTime { get; init; }

    /// <summary>
    /// Number of decimal places to which quantities of units/shares are rounded.
    /// </summary>
    [IsoId("_D4puR0lNEeiZP-CimVE7Hg")]
    [DisplayName("Decimalisation Units")]
    [IsoXmlTag("DcmlstnUnits")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DecimalisationUnits { get; init; }

    /// <summary>
    /// Number of decimal places to which the price is rounded.
    /// </summary>
    [IsoId("_D4puSUlNEeiZP-CimVE7Hg")]
    [DisplayName("Decimalisation Price")]
    [IsoXmlTag("DcmlstnPric")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? DecimalisationPrice { get; init; }

    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("_D4puS0lNEeiZP-CimVE7Hg")]
    [DisplayName("Dual Fund Indicator")]
    [IsoXmlTag("DualFndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DualFundIndicator { get; init; }

    /// <summary>
    /// Type of pricing calculation method.
    /// </summary>
    [IsoId("_D4puTUlNEeiZP-CimVE7Hg")]
    [DisplayName("Price Method")]
    [IsoXmlTag("PricMtd")]
    public PriceMethod1Code? PriceMethod { get; init; }

    /// <summary>
    /// Currencies in which the prices for the investment fund class are published by the fund management company.
    /// </summary>
    [IsoId("_D4puT0lNEeiZP-CimVE7Hg")]
    [DisplayName("Price Currency")]
    [IsoXmlTag("PricCcy")]
    public SimpleValueList<ActiveCurrencyCode> PriceCurrency { get; init; } = [];

    /// <summary>
    /// Additional information about the valuation dealing characteristics.
    /// </summary>
    [IsoId("_TaV6cWAKEeiNMJ262H2pWg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
