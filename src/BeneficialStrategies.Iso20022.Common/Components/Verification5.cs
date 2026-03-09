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
[IsoId("_YSPLwcVVEeuPIIgba4mCug")]
[DisplayName("Verification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Verification5
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
    [IsoId("_YYHKQcVVEeuPIIgba4mCug")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalAuthenticationMethod1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Type { get; init; } 
    #else
    public string? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of authentication or verification.
    /// </summary>
    [IsoId("_YYHKQ8VVEeuPIIgba4mCug")]
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
    [IsoId("_YYHKRcVVEeuPIIgba4mCug")]
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
    [IsoId("_YYHKR8VVEeuPIIgba4mCug")]
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
    [IsoId("_YYHKScVVEeuPIIgba4mCug")]
    [DisplayName("Verification Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VrfctnRslt")]
    #endif
    [IsoXmlTag("VrfctnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VerificationResult2? VerificationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VerificationResult2? VerificationResult { get; init; } 
    #else
    public VerificationResult2? VerificationResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}
