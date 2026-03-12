// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to report on a member.
/// </summary>
[IsoId("_tb1HSZlVEeeE1Ya-LgRsuQ")]
[DisplayName("Member Return Criteria")]
public partial record MemberReturnCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the member name is requested.
    /// </summary>
    [IsoId("_tj1zwZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Name Indicator")]
    [IsoXmlTag("NmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? NameIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the member return address is requested.
    /// </summary>
    [IsoId("_tj1zw5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("Member Return Address Indicator")]
    [IsoXmlTag("MmbRtrAdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MemberReturnAddressIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the member account is requested.
    /// </summary>
    [IsoId("_tj1zxZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Account Indicator")]
    [IsoXmlTag("AcctInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? AccountIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the member type is requested.
    /// </summary>
    [IsoId("_tj1zx5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("Type Indicator")]
    [IsoXmlTag("TpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TypeIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the member status is requested.
    /// </summary>
    [IsoId("_tj1zyZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Status Indicator")]
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? StatusIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the contact references are requested.
    /// </summary>
    [IsoId("_tj1zy5lVEeeE1Ya-LgRsuQ")]
    [DisplayName("Contact Reference Indicator")]
    [IsoXmlTag("CtctRefInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ContactReferenceIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the communication addresses are requested.
    /// </summary>
    [IsoId("_tj1zzZlVEeeE1Ya-LgRsuQ")]
    [DisplayName("Communication Address Indicator")]
    [IsoXmlTag("ComAdrInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CommunicationAddressIndicator { get; init; } 
    
    
    #nullable disable
    
}
