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
[IsoId("_Weu8C9p-Ed-ak6NoX_4Aeg_-1232539888")]
[DisplayName("Financial Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrument22
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, for example, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, for example, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_Weu8DNp-Ed-ak6NoX_4Aeg_1861417460")]
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
    /// Specifies the form, that is, ownership, of the security.
    /// </summary>
    [IsoId("_We4tANp-Ed-ak6NoX_4Aeg_-132727246")]
    [DisplayName("Securities Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesForm")]
    #endif
    [IsoXmlTag("SctiesForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    #else
    public FormOfSecurity1Code? SecuritiesForm { get; set; } 
    #endif
    
    /// <summary>
    /// Income policy relating to a class type, that is, if income is paid out or retained in the fund.
    /// </summary>
    [IsoId("_We4tAdp-Ed-ak6NoX_4Aeg_-2126871952")]
    [DisplayName("Distribution Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnPlcy")]
    #endif
    [IsoXmlTag("DstrbtnPlcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionPolicy1Code? DistributionPolicy { get; init; } 
    #else
    public DistributionPolicy1Code? DistributionPolicy { get; set; } 
    #endif
    
    /// <summary>
    /// Company specific description of a group of funds.
    /// </summary>
    [IsoId("_We4tAtp-Ed-ak6NoX_4Aeg_173950638")]
    [DisplayName("Product Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctGrp")]
    #endif
    [IsoXmlTag("PdctGrp")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? ProductGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductGroup { get; init; } 
    #else
    public System.String? ProductGroup { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the umbrella fund in which financial instrument is contained.
    /// </summary>
    [IsoId("_We4tA9p-Ed-ak6NoX_4Aeg_-1820194068")]
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
    /// Currency of the investment fund class.
    /// </summary>
    [IsoId("_We4tBNp-Ed-ak6NoX_4Aeg_480628522")]
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
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_We4tBdp-Ed-ak6NoX_4Aeg_-1513516184")]
    [DisplayName("Denomination Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DnmtnCcy")]
    #endif
    [IsoXmlTag("DnmtnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? DenominationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DenominationCurrency { get; init; } 
    #else
    public string? DenominationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency to be used for pricing the fund. This currency must be among the set of currencies in which the price may be expressed, as stated in the prospectus.
    /// </summary>
    [IsoId("_We4tBtp-Ed-ak6NoX_4Aeg_-900160416")]
    [DisplayName("Requested NAV Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdNAVCcy")]
    #endif
    [IsoXmlTag("ReqdNAVCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? RequestedNAVCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RequestedNAVCurrency { get; init; } 
    #else
    public string? RequestedNAVCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the fund has two prices.
    /// </summary>
    [IsoId("_We4tB9p-Ed-ak6NoX_4Aeg_1400662174")]
    [DisplayName("Dual Fund Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DualFndInd")]
    #endif
    [IsoXmlTag("DualFndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DualFundIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DualFundIndicator { get; init; } 
    #else
    public System.String? DualFundIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the fund has legal domicile as reflected in the ISIN classification.
    /// </summary>
    [IsoId("_We4tCNp-Ed-ak6NoX_4Aeg_1625110260")]
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
    /// Countries where the fund is registered for distribution.
    /// </summary>
    [IsoId("_We4tCdp-Ed-ak6NoX_4Aeg_-369034446")]
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
    
    
    #nullable disable
    
}
