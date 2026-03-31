// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Option244.
/// </summary>
[IsoId("_kv5X4Zt3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Option244")]
public record CorporateActionOption244
{
    /// <summary>
    /// Cash Movement Details.
    /// </summary>
    [DisplayName("Cash Movement Details")]
    [IsoXmlTag("CshMvmntDtls")]
    public ValueList<CashOption110> CashMovementDetails { get; init; } = [];

    /// <summary>
    /// Currency Option.
    /// </summary>
    [DisplayName("Currency Option")]
    [IsoXmlTag("CcyOptn")]
    public ActiveCurrencyCode? CurrencyOption { get; init; }

    /// <summary>
    /// Date Details.
    /// </summary>
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate109? DateDetails { get; init; }

    /// <summary>
    /// Fraction Disposition.
    /// </summary>
    [DisplayName("Fraction Disposition")]
    [IsoXmlTag("FrctnDspstn")]
    public FractionDispositionType30Choice_? FractionDisposition { get; init; }

    /// <summary>
    /// Option Features.
    /// </summary>
    [DisplayName("Option Features")]
    [IsoXmlTag("OptnFeatrs")]
    public ValueList<OptionFeaturesFormat30Choice_> OptionFeatures { get; init; } = [];

    /// <summary>
    /// Option Number.
    /// </summary>
    [DisplayName("Option Number")]
    [IsoXmlTag("OptnNb")]
    public required OptionNumber1Choice_ OptionNumber { get; init; }

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public required CorporateActionOption39Choice_ OptionType { get; init; }

    /// <summary>
    /// Period Details.
    /// </summary>
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod13? PeriodDetails { get; init; }

    /// <summary>
    /// Place Of Trade.
    /// </summary>
    [DisplayName("Place Of Trade")]
    [IsoXmlTag("PlcOfTrad")]
    public MarketIdentification90? PlaceOfTrade { get; init; }

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice92? PriceDetails { get; init; }

    /// <summary>
    /// Rate And Amount Details.
    /// </summary>
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate131? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Securities Movement Details.
    /// </summary>
    [DisplayName("Securities Movement Details")]
    [IsoXmlTag("SctiesMvmntDtls")]
    public ValueList<SecuritiesOption115> SecuritiesMovementDetails { get; init; } = [];
}
