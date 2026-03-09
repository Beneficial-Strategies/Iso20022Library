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
/// Result of performed verifications for the transaction.
/// </summary>
[IsoId("_9soGsYocEeSirOZJBRz_nA")]
[DisplayName("Transaction Verification Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionVerificationResult5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionVerificationResult5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionVerificationResult5( AuthenticationMethod7Code reqMethod )
    {
        Method = reqMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Method of verification that has been performed.
    /// </summary>
    [IsoId("_95gsIYocEeSirOZJBRz_nA")]
    [DisplayName("Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mtd")]
    #endif
    [IsoXmlTag("Mtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthenticationMethod7Code Method { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthenticationMethod7Code Method { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationMethod7Code Method { get; init; } 
    #else
    public AuthenticationMethod7Code Method { get; set; } 
    #endif
    
    /// <summary>
    /// Entity or device that has performed the verification.
    /// </summary>
    [IsoId("_95gsI4ocEeSirOZJBRz_nA")]
    [DisplayName("Verification Entity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VrfctnNtty")]
    #endif
    [IsoXmlTag("VrfctnNtty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AuthenticationEntity2Code? VerificationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthenticationEntity2Code? VerificationEntity { get; init; } 
    #else
    public AuthenticationEntity2Code? VerificationEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the verification.
    /// </summary>
    [IsoId("_95gsJYocEeSirOZJBRz_nA")]
    [DisplayName("Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rslt")]
    #endif
    [IsoXmlTag("Rslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Verification1Code? Result { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Verification1Code? Result { get; init; } 
    #else
    public Verification1Code? Result { get; set; } 
    #endif
    
    /// <summary>
    /// Additional result of the verification.
    /// </summary>
    [IsoId("_95gsJ4ocEeSirOZJBRz_nA")]
    [DisplayName("Additional Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRslt")]
    #endif
    [IsoXmlTag("AddtlRslt")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? AdditionalResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalResult { get; init; } 
    #else
    public System.String? AdditionalResult { get; set; } 
    #endif
    
    /// <summary>
    /// Token provided to the ATM for further proof of authentication.
    /// </summary>
    [IsoId("_YIjy8IodEeSirOZJBRz_nA")]
    [DisplayName("Authentication Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnTkn")]
    #endif
    [IsoXmlTag("AuthntcnTkn")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? AuthenticationToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AuthenticationToken { get; init; } 
    #else
    public System.Byte[]? AuthenticationToken { get; set; } 
    #endif
    
    
    #nullable disable
    
}
