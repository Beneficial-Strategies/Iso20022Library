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
/// Defines the criteria used to report on a system or a member of the system.
/// </summary>
[IsoId("_RD_KlNp-Ed-ak6NoX_4Aeg_5460592")]
[DisplayName("System Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemReturnCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the system identification is requested.
    /// </summary>
    [IsoId("_RD_Kldp-Ed-ak6NoX_4Aeg_5460611")]
    [DisplayName("System Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysIdInd")]
    #endif
    [IsoXmlTag("SysIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SystemIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemIdentificationIndicator { get; init; } 
    #else
    public System.String? SystemIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the member identification is requested.
    /// </summary>
    [IsoId("_RD_Kltp-Ed-ak6NoX_4Aeg_5460652")]
    [DisplayName("Member Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbIdInd")]
    #endif
    [IsoXmlTag("MmbIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? MemberIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MemberIdentificationIndicator { get; init; } 
    #else
    public System.String? MemberIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the country identification is requested.
    /// </summary>
    [IsoId("_RD_Kl9p-Ed-ak6NoX_4Aeg_348086000")]
    [DisplayName("Country Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryIdInd")]
    #endif
    [IsoXmlTag("CtryIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CountryIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CountryIdentificationIndicator { get; init; } 
    #else
    public System.String? CountryIdentificationIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the account identification is requested.
    /// </summary>
    [IsoId("_RD_KmNp-Ed-ak6NoX_4Aeg_762169796")]
    [DisplayName("Account Identification Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctIdInd")]
    #endif
    [IsoXmlTag("AcctIdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountIdentificationIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIdentificationIndicator { get; init; } 
    #else
    public System.String? AccountIdentificationIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
