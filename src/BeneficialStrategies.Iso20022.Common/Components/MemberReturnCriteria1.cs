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
/// Defines the criteria used to report on a member.
/// </summary>
[IsoId("_tb1HSZlVEeeE1Ya-LgRsuQ")]
[DisplayName("Member Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MemberReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the member name is requested.
    /// </summary>
    [IsoId("_tj1zwZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Name Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmInd")]
    #endif
    [IsoXmlTag("NmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? NameIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NameIndicator { get; init; } 
    #else
    public System.String? NameIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the member return address is requested.
    /// </summary>
    [IsoId("_tj1zw5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("Member Return Address Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MmbRtrAdrInd")]
    #endif
    [IsoXmlTag("MmbRtrAdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? MemberReturnAddressIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MemberReturnAddressIndicator { get; init; } 
    #else
    public System.String? MemberReturnAddressIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the member account is requested.
    /// </summary>
    [IsoId("_tj1zxZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctInd")]
    #endif
    [IsoXmlTag("AcctInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? AccountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountIndicator { get; init; } 
    #else
    public System.String? AccountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the member type is requested.
    /// </summary>
    [IsoId("_tj1zx5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpInd")]
    #endif
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? TypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TypeIndicator { get; init; } 
    #else
    public System.String? TypeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the member status is requested.
    /// </summary>
    [IsoId("_tj1zyZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Status Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInd")]
    #endif
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? StatusIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatusIndicator { get; init; } 
    #else
    public System.String? StatusIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the contact references are requested.
    /// </summary>
    [IsoId("_tj1zy5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("Contact Reference Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctRefInd")]
    #endif
    [IsoXmlTag("CtctRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ContactReferenceIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContactReferenceIndicator { get; init; } 
    #else
    public System.String? ContactReferenceIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the communication addresses are requested.
    /// </summary>
    [IsoId("_tj1zzZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Communication Address Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComAdrInd")]
    #endif
    [IsoXmlTag("ComAdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? CommunicationAddressIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommunicationAddressIndicator { get; init; } 
    #else
    public System.String? CommunicationAddressIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
