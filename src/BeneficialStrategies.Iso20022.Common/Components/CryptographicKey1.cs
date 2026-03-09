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
/// Cryptographic Key to exchange.
/// </summary>
[IsoId("_K8nIQn1DEeCF8NjrBemJWQ_387457534")]
[DisplayName("Cryptographic Key")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CryptographicKey1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CryptographicKey1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CryptographicKey1( System.String reqIdentification,System.String reqVersion,ContentInformationType2 reqKeyValue )
    {
        Identification = reqIdentification;
        Version = reqVersion;
        KeyValue = reqKeyValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_K8nIQ31DEeCF8NjrBemJWQ_559775138")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional identification of the key.
    /// Usage
    /// For derived unique key per transaction (DUKPT) keys, the key serial number (KSN) with the 21 bits of the transaction counter set to zero.
    /// </summary>
    [IsoId("_K8nIRH1DEeCF8NjrBemJWQ_-1354243077")]
    [DisplayName("Additional Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlId")]
    #endif
    [IsoXmlTag("AddtlId")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? AdditionalIdentification { get; init; } 
    #else
    public System.Byte[]? AdditionalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_K8nIRX1DEeCF8NjrBemJWQ_-624647251")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Exact10Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact10Text Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Version { get; init; } 
    #else
    public System.String Version { get; set; } 
    #endif
    
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_K8nIRn1DEeCF8NjrBemJWQ_-2129184862")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKeyType1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKeyType1Code? Type { get; init; } 
    #else
    public CryptographicKeyType1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_K8nIR31DEeCF8NjrBemJWQ_-756931989")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = new SimpleValueList<KeyUsage1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _K8nIR31DEeCF8NjrBemJWQ_-756931989
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_K8nISH1DEeCF8NjrBemJWQ_838743499")]
    [DisplayName("Activation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvtnDt")]
    #endif
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ActivationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ActivationDate { get; init; } 
    #else
    public System.DateTime? ActivationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [IsoId("_K8nISX1DEeCF8NjrBemJWQ_1414724439")]
    [DisplayName("Deactivation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DeactvtnDt")]
    #endif
    [IsoXmlTag("DeactvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? DeactivationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? DeactivationDate { get; init; } 
    #else
    public System.DateTime? DeactivationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted cryptographic key.
    /// </summary>
    [IsoId("_K8wSMH1DEeCF8NjrBemJWQ_-1603310801")]
    [DisplayName("Key Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyVal")]
    #endif
    [IsoXmlTag("KeyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType2 KeyValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentInformationType2 KeyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType2 KeyValue { get; init; } 
    #else
    public ContentInformationType2 KeyValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
