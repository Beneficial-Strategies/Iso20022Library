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
[IsoId("_buLRmTQbEeifw8iDiyZLmQ")]
[DisplayName("Security Identification")]
public record SecurityIdentification36
{
    /// <summary>
    /// Identification of the security, typically by an ISIN.
    /// </summary>
    [IsoId("_b-Pt0TQbEeifw8iDiyZLmQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification19 Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_b-Pt0zQbEeifw8iDiyZLmQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_hroqIUkyEeiZP-CimVE7Hg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_b-Pt1TQbEeifw8iDiyZLmQ")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; }

    /// <summary>
    /// Name of the umbrella fund in which the financial instrument is contained.
    /// </summary>
    [IsoId("_b-Pt1zQbEeifw8iDiyZLmQ")]
    [DisplayName("Umbrella Name")]
    [IsoXmlTag("UmbrllNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? UmbrellaName { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is part of a new umbrella.
    /// </summary>
    [IsoId("_aVK5YHiGEeij0vbhRaNJcw")]
    [DisplayName("New Umbrella")]
    [IsoXmlTag("NewUmbrll")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewUmbrella { get; init; }

    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_WWzf5EkyEeiZP-CimVE7Hg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public SecurityClassificationType2Choice_? ClassificationType { get; init; }

    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_b-Pt2TQbEeifw8iDiyZLmQ")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public ActiveCurrencyCode? BaseCurrency { get; init; }

    /// <summary>
    /// Country where the fund has legal domicile.
    /// </summary>
    [IsoId("_b-Pt2zQbEeifw8iDiyZLmQ")]
    [DisplayName("Country Of Domicile")]
    [IsoXmlTag("CtryOfDmcl")]
    public CountryCode? CountryOfDomicile { get; init; }

    /// <summary>
    /// Country where the fund is registered for distribution.
    /// </summary>
    [IsoId("_b-Pt3TQbEeifw8iDiyZLmQ")]
    [DisplayName("Registered Distribution Country")]
    [IsoXmlTag("RegdDstrbtnCtry")]
    public SimpleValueList<CountryCode> RegisteredDistributionCountry { get; init; } = [];

    /// <summary>
    /// Legal structure of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00060.
    /// </summary>
    [IsoId("_bBitoDQeEeifw8iDiyZLmQ")]
    [DisplayName("Legal Structure")]
    [IsoXmlTag("LglStr")]
    public LegalStructure1Choice_? LegalStructure { get; init; }

    /// <summary>
    /// Issuer of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00070.
    /// </summary>
    [IsoId("_EMp7wj4-Eeih8-WNbS6hbA")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public ContactAttributes5? Issuer { get; init; }

    /// <summary>
    /// Governance procedure that must be followed. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00075.
    /// </summary>
    [IsoId("_UX2W8ID4Eeiw-daIkkmMqQ")]
    [DisplayName("Issuer Product Governance Process")]
    [IsoXmlTag("IssrPdctGovncPrc")]
    public GovernanceProcess1Choice_? IssuerProductGovernanceProcess { get; init; }

    /// <summary>
    /// Designation of the product category or nature, for example, Pacific Equity, Equity Fund, Money Market Fund. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00090. If the product is a structured security product, the European Structured Investment Products Association (EUSIPA) code should be used as defined in the scope of European MiFID Template (EMT) reference 00095.
    /// In EMT v1, this is &apos;Designation of the respective product category or nature&apos;.
    /// In EMT v2, this is &apos;Designation of the respective product category or nature for Germany’.
    /// If the financial instrument is distributed in the German market, then the German classification of financial instruments code should be used.
    /// </summary>
    [IsoId("_f_EssDQgEeifw8iDiyZLmQ")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? ProductCategory { get; init; }

    /// <summary>
    /// When the financial instrument is a structured security, specifies if the ex-ante and ex-post costs and charges are specified as an absolute figure, that is, a currency and amount, or as a percentage rate, related to the specific reference value.
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT v2) reference 00096 or the European MiFID Template (EMT v1) reference 07010.
    /// </summary>
    [IsoId("_kx128NK3EeihtcVwfFPNlg")]
    [DisplayName("Quotation Type")]
    [IsoXmlTag("QtnTp")]
    public QuotationType1Choice_? QuotationType { get; init; }

    /// <summary>
    /// Indicates whether the financial instrument is leveraged or has contingent liability. This enables reporting on the depreciation of leveraged financial instruments or contingent liability transactions in accordance with Art. 62 of the MiFID II&apos;s Delegated Regulation as defined in the scope of European MiFID Template (EMT) reference 00100.
    /// </summary>
    [IsoId("_aoplIDQhEeifw8iDiyZLmQ")]
    [DisplayName("Leveraged Or Contigent Liability")]
    [IsoXmlTag("LvrgdOrCntgntLblty")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LeveragedOrContigentLiability { get; init; }

    /// <summary>
    /// Additional information about the security.
    /// </summary>
    [IsoId("_u4TOcD8bEeihnuqe1O9WPQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
