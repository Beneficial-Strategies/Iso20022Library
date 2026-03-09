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
/// Result of verifications performed prior or after the transaction.
/// </summary>
[IsoId("_8prHcSYDEeym0KcvJF9aDQ")]
[DisplayName("Verification Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VerificationResult2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of the verification or authentication.
    /// </summary>
    [IsoId("_8uxp4SYDEeym0KcvJF9aDQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Type { get; init; } 
    #else
    public System.String? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Entity who actually performed the verification.
    /// ISO 8583:93 bit 22-9
    /// </summary>
    [IsoId("_8uxp4yYDEeym0KcvJF9aDQ")]
    [DisplayName("Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntty")]
    #endif
    [IsoXmlTag("Ntty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public VerificationEntity2Code? Entity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VerificationEntity2Code? Entity { get; init; } 
    #else
    public VerificationEntity2Code? Entity { get; set; } 
    #endif
    
    /// <summary>
    /// Other national or private entity in charge of the verification.
    /// </summary>
    [IsoId("_8uxp5SYDEeym0KcvJF9aDQ")]
    [DisplayName("Other Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrNtty")]
    #endif
    [IsoXmlTag("OthrNtty")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherEntity { get; init; } 
    #else
    public System.String? OtherEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the verification.
    /// </summary>
    [IsoId("_8uxp5yYDEeym0KcvJF9aDQ")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Verification3Code? Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Verification3Code? Result { get; init; } 
    #else
    public Verification3Code? Result { get; set; } 
    #endif
    
    /// <summary>
    /// Additional result of the verification, for instance for electronic commerce.
    /// </summary>
    [IsoId("_8uxp6SYDEeym0KcvJF9aDQ")]
    [DisplayName("Other Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRslt")]
    #endif
    [IsoXmlTag("OthrRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? OtherResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherResult { get; init; } 
    #else
    public System.String? OtherResult { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the result.
    /// </summary>
    [IsoId("_8uxp6yYDEeym0KcvJF9aDQ")]
    [DisplayName("Result Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltDtls")]
    #endif
    [IsoXmlTag("RsltDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? ResultDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? ResultDetails { get; init; } 
    #else
    public AdditionalData1? ResultDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
