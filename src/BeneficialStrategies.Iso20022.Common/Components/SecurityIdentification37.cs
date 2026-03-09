// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_LXEL8Z9DEeqxTNfi5y7ywQ")]
[DisplayName("Security Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentification37
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityIdentification37 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityIdentification37( SecurityIdentification19 reqIdentification,System.String reqName )
    {
        Identification = reqIdentification;
        Name = reqName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the security, typically by an ISIN.
    /// </summary>
    [IsoId("_LtFfQ59DEeqxTNfi5y7ywQ")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 Identification { get; init; } 
    #else
    public SecurityIdentification19 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_LtFfRZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_LtFfR59DEeqxTNfi5y7ywQ")]
    [DisplayName("Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtNm")]
    #endif
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ShortName { get; init; } 
    #else
    public System.String? ShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, for example, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, for example, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_LtFfSZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Class Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssTp")]
    #endif
    [IsoXmlTag("ClssTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClassType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassType { get; init; } 
    #else
    public System.String? ClassType { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the umbrella fund in which the financial instrument is contained.
    /// </summary>
    [IsoId("_LtFfS59DEeqxTNfi5y7ywQ")]
    [DisplayName("Umbrella Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UmbrllNm")]
    #endif
    [IsoXmlTag("UmbrllNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? UmbrellaName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UmbrellaName { get; init; } 
    #else
    public System.String? UmbrellaName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is part of a new umbrella.
    /// </summary>
    [IsoId("_LtFfTZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("New Umbrella")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewUmbrll")]
    #endif
    [IsoXmlTag("NewUmbrll")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NewUmbrella { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewUmbrella { get; init; } 
    #else
    public System.String? NewUmbrella { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO Classification of Financial Instrument (CFI) codification, for example, common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_LtFfT59DEeqxTNfi5y7ywQ")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityClassificationType2Choice_? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityClassificationType2Choice_? ClassificationType { get; init; } 
    #else
    public SecurityClassificationType2Choice_? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_LtFfV59DEeqxTNfi5y7ywQ")]
    [DisplayName("Base Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseCcy")]
    #endif
    [IsoXmlTag("BaseCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? BaseCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? BaseCurrency { get; init; } 
    #else
    public string? BaseCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the fund has legal domicile.
    /// </summary>
    [IsoId("_LtFfWZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Country Of Domicile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfDmcl")]
    #endif
    [IsoXmlTag("CtryOfDmcl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? CountryOfDomicile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? CountryOfDomicile { get; init; } 
    #else
    public string? CountryOfDomicile { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the fund is registered for distribution.
    /// </summary>
    [IsoId("_LtFfW59DEeqxTNfi5y7ywQ")]
    [DisplayName("Registered Distribution Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdDstrbtnCtry")]
    #endif
    [IsoXmlTag("RegdDstrbtnCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? RegisteredDistributionCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RegisteredDistributionCountry { get; init; } 
    #else
    public string? RegisteredDistributionCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00060.
    /// </summary>
    [IsoId("_LtFfXZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Product Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctTp")]
    #endif
    [IsoXmlTag("PdctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductStructure1Choice_? ProductType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductStructure1Choice_? ProductType { get; init; } 
    #else
    public ProductStructure1Choice_? ProductType { get; set; } 
    #endif
    
    /// <summary>
    /// Issuer of the financial instrument. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00070.
    /// </summary>
    [IsoId("_LtFfX59DEeqxTNfi5y7ywQ")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactAttributes5? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactAttributes5? Issuer { get; init; } 
    #else
    public ContactAttributes5? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Governance procedure that must be followed. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00075.
    /// </summary>
    [IsoId("_LtFfYZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Issuer Product Governance Process")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrPdctGovncPrc")]
    #endif
    [IsoXmlTag("IssrPdctGovncPrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GovernanceProcess1Choice_? IssuerProductGovernanceProcess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GovernanceProcess1Choice_? IssuerProductGovernanceProcess { get; init; } 
    #else
    public GovernanceProcess1Choice_? IssuerProductGovernanceProcess { get; set; } 
    #endif
    
    /// <summary>
    /// Designation of the product category or nature, for example, Pacific Equity, Equity Fund, Money Market Fund. If the product is a structured security product, the European Structured Investment Products Association (EUSIPA) code should be used as defined in the scope of European MiFID Template (EMT) reference 00095. 
    /// </summary>
    [IsoId("_LtFfY59DEeqxTNfi5y7ywQ")]
    [DisplayName("Product Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCtgy")]
    #endif
    [IsoXmlTag("PdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ProductCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductCategory { get; init; } 
    #else
    public System.String? ProductCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Designation of the respective product category or nature for Germany.
    /// If the financial instrument is distributed in the German market, then the German classification of financial instruments code should be used. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00090.
    /// </summary>
    [IsoId("_o60KcZ9TEeqxTNfi5y7ywQ")]
    [DisplayName("Product Category Germany")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctCtgyDE")]
    #endif
    [IsoXmlTag("PdctCtgyDE")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? ProductCategoryGermany { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductCategoryGermany { get; init; } 
    #else
    public System.String? ProductCategoryGermany { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the financial instrument is unit based or notional (nominal). When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00085.
    /// </summary>
    [IsoId("_HQ5ioJ9VEeqxTNfi5y7ywQ")]
    [DisplayName("Notional Or Unit Based")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlOrUnitBased")]
    #endif
    [IsoXmlTag("NtnlOrUnitBased")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalOrUnitBased1Choice_? NotionalOrUnitBased { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalOrUnitBased1Choice_? NotionalOrUnitBased { get; init; } 
    #else
    public NotionalOrUnitBased1Choice_? NotionalOrUnitBased { get; set; } 
    #endif
    
    /// <summary>
    /// When the financial instrument is a structured security, specifies if the ex-ante and ex-post costs and charges are specified as an absolute figure, that is, a currency and amount, or as a percentage rate, related to the specific reference value. 
    /// When used in reference to MiFID, this is in the scope of the European MiFID Template reference 00096.
    /// </summary>
    [IsoId("_LtFfZZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Quotation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtnTp")]
    #endif
    [IsoXmlTag("QtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuotationType1Choice_? QuotationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuotationType1Choice_? QuotationType { get; init; } 
    #else
    public QuotationType1Choice_? QuotationType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is leveraged or has contingent liability. This enables reporting on the depreciation of leveraged financial instruments or contingent liability transactions in accordance with Art. 62 of the MiFID II&apos;s Delegated Regulation as defined in the scope of European MiFID Template (EMT) reference 00100.
    /// </summary>
    [IsoId("_LtFfZ59DEeqxTNfi5y7ywQ")]
    [DisplayName("Leveraged Or Contigent Liability")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LvrgdOrCntgntLblty")]
    #endif
    [IsoXmlTag("LvrgdOrCntgntLblty")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LeveragedOrContigentLiability { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LeveragedOrContigentLiability { get; init; } 
    #else
    public System.String? LeveragedOrContigentLiability { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the share class does not pay retrocession fees and commissions. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00110.
    /// </summary>
    [IsoId("_zaEiIZ9UEeqxTNfi5y7ywQ")]
    [DisplayName("No Retrocession Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NoRtrcssnInd")]
    #endif
    [IsoXmlTag("NoRtrcssnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? NoRetrocessionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NoRetrocessionIndicator { get; init; } 
    #else
    public System.String? NoRetrocessionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the basis for ex-post calculations. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 00120.
    /// </summary>
    [IsoId("_Votq0J9XEeqxTNfi5y7ywQ")]
    [DisplayName("Ex Post Cost Calculation Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExPstCostClctnBsis")]
    #endif
    [IsoXmlTag("ExPstCostClctnBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExPostCostCalculationBasis1Choice_? ExPostCostCalculationBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExPostCostCalculationBasis1Choice_? ExPostCostCalculationBasis { get; init; } 
    #else
    public ExPostCostCalculationBasis1Choice_? ExPostCostCalculationBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the security.
    /// </summary>
    [IsoId("_LtFfaZ9DEeqxTNfi5y7ywQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
