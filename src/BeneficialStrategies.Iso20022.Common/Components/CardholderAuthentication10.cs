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
[IsoId("_RprEsLACEeah1_v59tW6Rg")]
[DisplayName("Cardholder Authentication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderAuthentication10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardholderAuthentication10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardholderAuthentication10( AuthenticationMethod5Code reqAuthenticationMethod )
    {
        AuthenticationMethod = reqAuthenticationMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_R4T9obACEeah1_v59tW6Rg")]
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
    [IsoId("_R4T9o7ACEeah1_v59tW6Rg")]
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
    [IsoId("_R4T9pbACEeah1_v59tW6Rg")]
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
    [IsoId("_R4T9p7ACEeah1_v59tW6Rg")]
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
    [IsoId("_R4T9qbACEeah1_v59tW6Rg")]
    [DisplayName("Cardholder Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrId")]
    #endif
    [IsoXmlTag("CrdhldrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonIdentification11? CardholderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentification11? CardholderIdentification { get; init; } 
    #else
    public PersonIdentification11? CardholderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_R4T9q7ACEeah1_v59tW6Rg")]
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
    
    /// <summary>
    /// Type of authentication for a given method - e.g. three-domain authentication, scheme-proprietary authentication, etc.
    /// </summary>
    [IsoId("_dkoa0LACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnTp")]
    #endif
    [IsoXmlTag("AuthntcnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AuthenticationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationType { get; init; } 
    #else
    public System.String? AuthenticationType { get; set; } 
    #endif
    
    /// <summary>
    /// Level of authentication for a given type – e.g. value assigned by scheme rules or by bilateral agreements.
    /// </summary>
    [IsoId("_kTh7wLACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnLvl")]
    #endif
    [IsoXmlTag("AuthntcnLvl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AuthenticationLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationLevel { get; init; } 
    #else
    public System.String? AuthenticationLevel { get; set; } 
    #endif
    
    /// <summary>
    /// Result of authentication.
    /// </summary>
    [IsoId("_sXw38LACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnRslt")]
    #endif
    [IsoXmlTag("AuthntcnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationResult1Code? AuthenticationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationResult1Code? AuthenticationResult { get; init; } 
    #else
    public AuthenticationResult1Code? AuthenticationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the result of the authentication.
    /// </summary>
    [IsoId("_48zs4LACEeah1_v59tW6Rg")]
    [DisplayName("Authentication Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnAddtlInf")]
    #endif
    [IsoXmlTag("AuthntcnAddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AuthenticationAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationAdditionalInformation { get; init; } 
    #else
    public System.String? AuthenticationAdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
