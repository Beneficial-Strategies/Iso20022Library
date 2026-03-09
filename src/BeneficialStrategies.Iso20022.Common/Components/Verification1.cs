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
/// Method and data intended to be verified as well as the related results.
/// </summary>
[IsoId("_aIR0sEbcEeeIjf8aP9KbJA")]
[DisplayName("Verification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Verification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of authentication or verification.
    /// </summary>
    [IsoId("_0ZNx4EbcEeeIjf8aP9KbJA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationMethod11Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod11Code? Type { get; init; } 
    #else
    public AuthenticationMethod11Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of authentication or verification.
    /// </summary>
    [IsoId("_7xHzkEbcEeeIjf8aP9KbJA")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of authentication for a given method (for example, three domain authentication, scheme proprietary solution, type of cryptogram, etc.).
    /// </summary>
    [IsoId("_RkuCwEbdEeeIjf8aP9KbJA")]
    [DisplayName("Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubTp")]
    #endif
    [IsoXmlTag("SubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubType { get; init; } 
    #else
    public System.String? SubType { get; set; } 
    #endif
    
    /// <summary>
    /// Contains verification or authentication data.
    /// </summary>
    [IsoId("_qxdYAEbdEeeIjf8aP9KbJA")]
    [DisplayName("Verification Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VrfctnInf")]
    #endif
    [IsoXmlTag("VrfctnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VerificationInformation1? VerificationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VerificationInformation1? VerificationInformation { get; init; } 
    #else
    public VerificationInformation1? VerificationInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Result of verifications performed prior or after the transaction.
    /// ISO 8583:93 bit 39
    /// ISO 8583:2003 bit 39 &amp; 49-72
    /// </summary>
    [IsoId("_Ouws0EbeEeeIjf8aP9KbJA")]
    [DisplayName("Verification Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VrfctnRslt")]
    #endif
    [IsoXmlTag("VrfctnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VerificationResult1? VerificationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VerificationResult1? VerificationResult { get; init; } 
    #else
    public VerificationResult1? VerificationResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
