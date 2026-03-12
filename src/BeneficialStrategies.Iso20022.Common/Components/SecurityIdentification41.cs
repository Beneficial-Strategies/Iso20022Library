// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_-tqH8dANEeuSBa1PsnseFg")]
[DisplayName("Security Identification")]
public partial record SecurityIdentification41
{
    #nullable enable
    
    /// <summary>
    /// Identification of the security, typically by an ISIN.
    /// </summary>
    [IsoId("__DHakdANEeuSBa1PsnseFg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification40 Identification { get; init; } 
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("__DHak9ANEeuSBa1PsnseFg")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("__DHaldANEeuSBa1PsnseFg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; } 
    
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("__DHal9ANEeuSBa1PsnseFg")]
    [DisplayName("Class Type")]
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClassType { get; init; } 
    
    /// <summary>
    /// Name of the umbrella fund in which the financial instrument is contained.
    /// </summary>
    [IsoId("__DHamdANEeuSBa1PsnseFg")]
    [DisplayName("Umbrella Name")]
    [IsoXmlTag("UmbrllNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? UmbrellaName { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument is part of a new umbrella.
    /// </summary>
    [IsoId("__DHam9ANEeuSBa1PsnseFg")]
    [DisplayName("New Umbrella")]
    [IsoXmlTag("NewUmbrll")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NewUmbrella { get; init; } 
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("__DHandANEeuSBa1PsnseFg")]
    [DisplayName("Classification Type")]
    [IsoXmlTag("ClssfctnTp")]
    public SecurityClassificationType2Choice_? ClassificationType { get; init; } 
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("__DHapdANEeuSBa1PsnseFg")]
    [DisplayName("Base Currency")]
    [IsoXmlTag("BaseCcy")]
    public ActiveCurrencyCode? BaseCurrency { get; init; } 
    
    /// <summary>
    /// Country where the fund has legal domicile.
    /// </summary>
    [IsoId("__DHap9ANEeuSBa1PsnseFg")]
    [DisplayName("Country Of Domicile")]
    [IsoXmlTag("CtryOfDmcl")]
    public CountryCode? CountryOfDomicile { get; init; } 
    
    /// <summary>
    /// Country where the fund is registered for distribution.
    /// </summary>
    [IsoId("__DHaqdANEeuSBa1PsnseFg")]
    [DisplayName("Registered Distribution Country")]
    [IsoXmlTag("RegdDstrbtnCtry")]
    public CountryCode? RegisteredDistributionCountry { get; init; } 
    
    /// <summary>
    /// Classification of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00060.
    /// </summary>
    [IsoId("__DHaq9ANEeuSBa1PsnseFg")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public ProductStructure1Choice_? ProductType { get; init; } 
    
    /// <summary>
    /// Issuer of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00070.
    /// </summary>
    [IsoId("__DHardANEeuSBa1PsnseFg")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public ContactAttributes5? Issuer { get; init; } 
    
    /// <summary>
    /// Governance procedure that must be followed. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00075.
    /// </summary>
    [IsoId("__DHar9ANEeuSBa1PsnseFg")]
    [DisplayName("Issuer Product Governance Process")]
    [IsoXmlTag("IssrPdctGovncPrc")]
    public GovernanceProcess1Choice_? IssuerProductGovernanceProcess { get; init; } 
    
    /// <summary>
    /// Designation of the product category or nature, for example, Pacific Equity, Equity Fund, Money Market Fund. If the product is a structured security product, the European Structured Investment Products Association (EUSIPA) code should be used as defined in the scope of European MiFID Template (EMT) reference 00095. 
    /// </summary>
    [IsoId("__DHasdANEeuSBa1PsnseFg")]
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? ProductCategory { get; init; } 
    
    /// <summary>
    /// Designation of the respective product category or nature for Germany.
    /// If the financial instrument is distributed in the German market, then the German classification of financial instruments code should be used. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00090.
    /// </summary>
    [IsoId("__DHas9ANEeuSBa1PsnseFg")]
    [DisplayName("Product Category Germany")]
    [IsoXmlTag("PdctCtgyDE")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? ProductCategoryGermany { get; init; } 
    
    /// <summary>
    /// Specifies whether the financial instrument is unit based or notional (nominal). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00085.
    /// </summary>
    [IsoId("__DHatdANEeuSBa1PsnseFg")]
    [DisplayName("Notional Or Unit Based")]
    [IsoXmlTag("NtnlOrUnitBased")]
    public NotionalOrUnitBased1Choice_? NotionalOrUnitBased { get; init; } 
    
    /// <summary>
    /// When the financial instrument is a structured security, specifies if the ex-ante and ex-post costs and charges are specified as an absolute figure, that is, a currency and amount, or as a percentage rate, related to the specific reference value. 
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template reference 00096.
    /// </summary>
    [IsoId("__DHat9ANEeuSBa1PsnseFg")]
    [DisplayName("Quotation Type")]
    [IsoXmlTag("QtnTp")]
    public QuotationType1Choice_? QuotationType { get; init; } 
    
    /// <summary>
    /// Indicates whether the financial instrument is leveraged or has contingent liability. This enables reporting on the depreciation of leveraged financial instruments or contingent liability transactions in accordance with Art. 62 of the MiFID II&apos;s Delegated Regulation as defined in the scope of European MiFID Template (EMT) reference 00100.
    /// </summary>
    [IsoId("__DHaudANEeuSBa1PsnseFg")]
    [DisplayName("Leveraged Or Contigent Liability")]
    [IsoXmlTag("LvrgdOrCntgntLblty")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LeveragedOrContigentLiability { get; init; } 
    
    /// <summary>
    /// Indicates whether the share class does not pay retrocession fees and commissions. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00110.
    /// </summary>
    [IsoId("__DHau9ANEeuSBa1PsnseFg")]
    [DisplayName("No Retrocession Indicator")]
    [IsoXmlTag("NoRtrcssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? NoRetrocessionIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the basis for ex-post calculations. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00120.
    /// </summary>
    [IsoId("__DHavdANEeuSBa1PsnseFg")]
    [DisplayName("Ex Post Cost Calculation Basis")]
    [IsoXmlTag("ExPstCostClctnBsis")]
    public ExPostCostCalculationBasis1Choice_? ExPostCostCalculationBasis { get; init; } 
    
    /// <summary>
    /// Additional information about the security.
    /// </summary>
    [IsoId("__DHav9ANEeuSBa1PsnseFg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
