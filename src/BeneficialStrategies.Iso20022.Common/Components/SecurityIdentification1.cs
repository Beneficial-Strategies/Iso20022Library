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
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_Scf1oNp-Ed-ak6NoX_4Aeg_277096217")]
[DisplayName("Security Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityIdentification1( SecurityIdentification7 reqIdentification,System.String reqName,string reqBaseCurrency,string reqCountryOfDomicile )
    {
        Identification = reqIdentification;
        Name = reqName;
        BaseCurrency = reqBaseCurrency;
        CountryOfDomicile = reqCountryOfDomicile;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_Scf1odp-Ed-ak6NoX_4Aeg_2092563069")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification7 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification7 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification7 Identification { get; init; } 
    #else
    public SecurityIdentification7 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_Scf1otp-Ed-ak6NoX_4Aeg_159174250")]
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
    /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, &apos;Class A&apos;, &apos;Class 2&apos;.
    /// </summary>
    [IsoId("_Scf1o9p-Ed-ak6NoX_4Aeg_159174311")]
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
    /// Name of the umbrella fund in which financial instrument is contained.
    /// </summary>
    [IsoId("_Scf1pNp-Ed-ak6NoX_4Aeg_159174342")]
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
    [IsoId("_Scf1pdp-Ed-ak6NoX_4Aeg_159174427")]
    [DisplayName("Base Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseCcy")]
    #endif
    [IsoXmlTag("BaseCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode BaseCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string BaseCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string BaseCurrency { get; init; } 
    #else
    public string BaseCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Country where the fund has legal domicile as reflected in the ISIN classification.
    /// </summary>
    [IsoId("_Scf1ptp-Ed-ak6NoX_4Aeg_159175290")]
    [DisplayName("Country Of Domicile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryOfDmcl")]
    #endif
    [IsoXmlTag("CtryOfDmcl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCode CountryOfDomicile { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CountryOfDomicile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CountryOfDomicile { get; init; } 
    #else
    public string CountryOfDomicile { get; set; } 
    #endif
    
    /// <summary>
    /// Countries where the fund is registered for distribution.
    /// </summary>
    [IsoId("_Scf1p9p-Ed-ak6NoX_4Aeg_159174373")]
    [DisplayName("Registered Distribution Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegdDstrbtnCtry")]
    #endif
    [IsoXmlTag("RegdDstrbtnCtry")]
    public SimpleValueList<string> RegisteredDistributionCountry { get; init; } = new SimpleValueList<string>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Scf1p9p-Ed-ak6NoX_4Aeg_159174373
    
    
    #nullable disable
    
}
