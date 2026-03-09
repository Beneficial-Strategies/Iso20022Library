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
[IsoId("_-PhO4QxuEeqdx6buGpCCQw")]
[DisplayName("Cardholder Authentication")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardholderAuthentication13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder or its card.
    /// </summary>
    [IsoId("_-bf1YQxuEeqdx6buGpCCQw")]
    [DisplayName("Authentication Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnMtd")]
    #endif
    [IsoXmlTag("AuthntcnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod8Code? AuthenticationMethod { get; init; } 
    #else
    public AuthenticationMethod8Code? AuthenticationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// If Strong Customer Authentication is not mandated to process the transaction, this message element must identify the reason of exemption.
    /// </summary>
    [IsoId("_2jG4oAx1Eeqdx6buGpCCQw")]
    [DisplayName("Authentication Exemption")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnXmptn")]
    #endif
    [IsoXmlTag("AuthntcnXmptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Exemption1Code? AuthenticationExemption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Exemption1Code? AuthenticationExemption { get; init; } 
    #else
    public Exemption1Code? AuthenticationExemption { get; set; } 
    #endif
    
    /// <summary>
    /// Value used to authenticate the cardholder.
    /// </summary>
    [IsoId("_-bf1YwxuEeqdx6buGpCCQw")]
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
    [IsoId("_-bf1ZQxuEeqdx6buGpCCQw")]
    [DisplayName("Protected Authentication Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdAuthntcnVal")]
    #endif
    [IsoXmlTag("PrtctdAuthntcnVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType22? ProtectedAuthenticationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType22? ProtectedAuthenticationValue { get; init; } 
    #else
    public ContentInformationType22? ProtectedAuthenticationValue { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted personal identification number (PIN) and related information.
    /// </summary>
    [IsoId("_-bf1ZwxuEeqdx6buGpCCQw")]
    [DisplayName("Cardholder On Line PIN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrOnLinePIN")]
    #endif
    [IsoXmlTag("CrdhldrOnLinePIN")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLinePIN7? CardholderOnLinePIN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLinePIN7? CardholderOnLinePIN { get; init; } 
    #else
    public OnLinePIN7? CardholderOnLinePIN { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the cardholder to verify.
    /// </summary>
    [IsoId("_-bf1aQxuEeqdx6buGpCCQw")]
    [DisplayName("Cardholder Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrId")]
    #endif
    [IsoXmlTag("CrdhldrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PersonIdentification15? CardholderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PersonIdentification15? CardholderIdentification { get; init; } 
    #else
    public PersonIdentification15? CardholderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Numeric characters of the cardholder&apos;s billing or shipping address for verification.
    /// </summary>
    [IsoId("_-bf1awxuEeqdx6buGpCCQw")]
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
    [IsoId("_-bf1bQxuEeqdx6buGpCCQw")]
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
    [IsoId("_-bf1bwxuEeqdx6buGpCCQw")]
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
    [IsoId("_-bf1cQxuEeqdx6buGpCCQw")]
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
    [IsoId("_-bf1cwxuEeqdx6buGpCCQw")]
    [DisplayName("Authentication Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnAddtlInf")]
    #endif
    [IsoXmlTag("AuthntcnAddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternallyDefinedData1? AuthenticationAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternallyDefinedData1? AuthenticationAdditionalInformation { get; init; } 
    #else
    public ExternallyDefinedData1? AuthenticationAdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
