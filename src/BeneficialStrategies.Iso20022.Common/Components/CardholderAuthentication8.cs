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
/// Data related to the authentication of the card and the cardholder.
/// </summary>
[IsoId("_UV3EwYoaEeSirOZJBRz_nA")]
[DisplayName("Cardholder Authentication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderAuthentication8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardholderAuthentication8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardholderAuthentication8( AuthenticationMethod7Code reqAuthenticationMethod )
    {
        AuthenticationMethod = reqAuthenticationMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the customer or its card.
    /// </summary>
    [IsoId("_UjTq4YoaEeSirOZJBRz_nA")]
    [DisplayName("Authentication Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnMtd")]
    #endif
    [IsoXmlTag("AuthntcnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthenticationMethod7Code AuthenticationMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthenticationMethod7Code AuthenticationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod7Code AuthenticationMethod { get; init; } 
    #else
    public AuthenticationMethod7Code AuthenticationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// True if an authentication token is requested to the host. This token will be provided to the ATM for further authentication.
    /// </summary>
    [IsoId("_bqLxgIobEeSirOZJBRz_nA")]
    [DisplayName("Token Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknReqd")]
    #endif
    [IsoXmlTag("TknReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? TokenRequested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenRequested { get; init; } 
    #else
    public System.String? TokenRequested { get; set; } 
    #endif
    
    /// <summary>
    /// Value or token to be used for customer or card authentication.
    /// </summary>
    [IsoId("_UjTq44oaEeSirOZJBRz_nA")]
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
    [IsoId("_UjTq5YoaEeSirOZJBRz_nA")]
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
    [IsoId("_UjTq54oaEeSirOZJBRz_nA")]
    [DisplayName("Cardholder On Line PIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrOnLinePIN")]
    #endif
    [IsoXmlTag("CrdhldrOnLinePIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLinePIN5? CardholderOnLinePIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLinePIN5? CardholderOnLinePIN { get; init; } 
    #else
    public OnLinePIN5? CardholderOnLinePIN { get; set; } 
    #endif
    
    
    #nullable disable
    
}
