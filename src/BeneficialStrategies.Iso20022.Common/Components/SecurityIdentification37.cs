// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_LXEL8Z9DEeqxTNfi5y7ywQ")]
[DisplayName("Security Identification")]
public record SecurityIdentification37
{
    /// <summary>
    /// Identification of the security, typically by an ISIN.
    /// </summary>
    [IsoId("_LtFfQ59DEeqxTNfi5y7ywQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification19 Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_LtFfRZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_LtFfR59DEeqxTNfi5y7ywQ")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_LtFfSZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Name of the umbrella fund in which the financial instrument is contained.
    /// </summary>
    [IsoId("_LtFfS59DEeqxTNfi5y7ywQ")]
    [DisplayName("Umbrella Name")]
    [IsoXmlTag("UmbrllNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? UmbrellaName { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is part of a new umbrella.
    /// </summary>
    [IsoId("_LtFfTZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("New Umbrella")]
    [IsoXmlTag("NewUmbrll")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewUmbrella { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_LtFfT59DEeqxTNfi5y7ywQ")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public SecurityClassificationType2Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_LtFfV59DEeqxTNfi5y7ywQ")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public ActiveCurrencyCode? BaseCurrency { get; init; }

    /// <summary>
    /// Country where the fund has legal domicile.
    /// </summary>
    [IsoId("_LtFfWZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Country Of Domicile")]
    [IsoXmlTag("CtryOfDmcl")]
    public CountryCode? CountryOfDomicile { get; init; }

    /// <summary>
    /// Country where the fund is registered for distribution.
    /// </summary>
    [IsoId("_LtFfW59DEeqxTNfi5y7ywQ")]
    [DisplayName("Registered Distribution Country")]
    [IsoXmlTag("RegdDstrbtnCtry")]
    public SimpleValueList<CountryCode> RegisteredDistributionCountry { get; init; } = [];

    /// <summary>
    /// Classification of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00060.
    /// </summary>
    [IsoId("_LtFfXZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public ProductStructure1Choice_? ProductType { get; init; }

    /// <summary>
    /// Issuer of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00070.
    /// </summary>
    [IsoId("_LtFfX59DEeqxTNfi5y7ywQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public ContactAttributes5? Issuer { get; init; }

    /// <summary>
    /// Governance procedure that must be followed. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00075.
    /// </summary>
    [IsoId("_LtFfYZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Issuer Product Governance Process")]
    [IsoXmlTag("IssrPdctGovncPrc")]
    public GovernanceProcess1Choice_? IssuerProductGovernanceProcess { get; init; }

    /// <summary>
    /// Designation of the product category or nature, for example, Pacific Equity, Equity Fund, Money Market Fund. If the product is a structured security product, the European Structured Investment Products Association (EUSIPA) code should be used as defined in the scope of European MiFID Template (EMT) reference 00095.
    /// </summary>
    [IsoId("_LtFfY59DEeqxTNfi5y7ywQ")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductCategory { get; init; }

    /// <summary>
    /// Designation of the respective product category or nature for Germany.
    /// If the financial instrument is distributed in the German market, then the German classification of financial instruments code should be used. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00090.
    /// </summary>
    [IsoId("_o60KcZ9TEeqxTNfi5y7ywQ")]
    [DisplayName("Product Category Germany")]
    [IsoXmlTag("PdctCtgyDE")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductCategoryGermany { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument is unit based or notional (nominal). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00085.
    /// </summary>
    [IsoId("_HQ5ioJ9VEeqxTNfi5y7ywQ")]
    [DisplayName("Notional Or Unit Based")]
    [IsoXmlTag("NtnlOrUnitBased")]
    public NotionalOrUnitBased1Choice_? NotionalOrUnitBased { get; init; }

    /// <summary>
    /// When the financial instrument is a structured security, specifies if the ex-ante and ex-post costs and charges are specified as an absolute figure, that is, a currency and amount, or as a percentage rate, related to the specific reference value.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template reference 00096.
    /// </summary>
    [IsoId("_LtFfZZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Quotation Type")]
    [IsoXmlTag("QtnTp")]
    public QuotationType1Choice_? QuotationType { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is leveraged or has contingent liability. This enables reporting on the depreciation of leveraged financial instruments or contingent liability transactions in accordance with Art. 62 of the MiFID II&apos;s Delegated Regulation as defined in the scope of European MiFID Template (EMT) reference 00100.
    /// </summary>
    [IsoId("_LtFfZ59DEeqxTNfi5y7ywQ")]
    [DisplayName("Leveraged Or Contigent Liability")]
    [IsoXmlTag("LvrgdOrCntgntLblty")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LeveragedOrContigentLiability { get; init; }

    /// <summary>
    /// Indicates whether the share class does not pay retrocession fees and commissions. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00110.
    /// </summary>
    [IsoId("_zaEiIZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("No Retrocession Indicator")]
    [IsoXmlTag("NoRtrcssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NoRetrocessionIndicator { get; init; }

    /// <summary>
    /// Specifies the basis for ex-post calculations. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00120.
    /// </summary>
    [IsoId("_Votq0J9XEeqxTNfi5y7ywQ")]
    [DisplayName("Ex Post Cost Calculation Basis")]
    [IsoXmlTag("ExPstCostClctnBsis")]
    public ExPostCostCalculationBasis1Choice_? ExPostCostCalculationBasis { get; init; }

    /// <summary>
    /// Additional information about the security.
    /// </summary>
    [IsoId("_LtFfaZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
