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
/// Data related to the authentication of the cardholder.
/// </summary>
[IsoId("_uzlg0YIDEeS7UOLM47txvA")]
[DisplayName("Cardholder Authentication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderAuthentication7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardholderAuthentication7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardholderAuthentication7( AuthenticationMethod5Code reqAuthenticationMethod )
    {
        AuthenticationMethod = reqAuthenticationMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_vAjl0YIDEeS7UOLM47txvA")]
    [DisplayName("Authentication Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnMtd")]
    #endif
    [IsoXmlTag("AuthntcnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthenticationMethod5Code AuthenticationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthenticationMethod5Code AuthenticationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod5Code AuthenticationMethod { get; init; } 
    #else
    public AuthenticationMethod5Code AuthenticationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_vAjl04IDEeS7UOLM47txvA")]
    [DisplayName("Authentication Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnVal")]
    #endif
    [IsoXmlTag("AuthntcnVal")]
    [IsoSimpleType(IsoSimpleType.Max5000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5000Binary? AuthenticationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AuthenticationValue { get; init; } 
    #else
    public System.Byte[]? AuthenticationValue { get; set; } 
    #endif
    
    /// <summary>
    /// Protection of the authentication value.
    /// </summary>
    [IsoId("_vAjl1YIDEeS7UOLM47txvA")]
    [DisplayName("Protected Authentication Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdAuthntcnVal")]
    #endif
    [IsoXmlTag("PrtctdAuthntcnVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedAuthenticationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedAuthenticationValue { get; init; } 
    #else
    public ContentInformationType10? ProtectedAuthenticationValue { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_vAjl14IDEeS7UOLM47txvA")]
    [DisplayName("Cardholder On Line PIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrOnLinePIN")]
    #endif
    [IsoXmlTag("CrdhldrOnLinePIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLinePIN4? CardholderOnLinePIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLinePIN4? CardholderOnLinePIN { get; init; } 
    #else
    public OnLinePIN4? CardholderOnLinePIN { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    [IsoId("_vB3IkC-2EeWfYucYWs4iQg")]
    [DisplayName("Cardholder Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrId")]
    #endif
    [IsoXmlTag("CrdhldrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonIdentification7? CardholderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentification7? CardholderIdentification { get; init; } 
    #else
    public PersonIdentification7? CardholderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_vAjl2YIDEeS7UOLM47txvA")]
    [DisplayName("Address Verification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdrVrfctn")]
    #endif
    [IsoXmlTag("AdrVrfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AddressVerification1? AddressVerification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AddressVerification1? AddressVerification { get; init; } 
    #else
    public AddressVerification1? AddressVerification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
