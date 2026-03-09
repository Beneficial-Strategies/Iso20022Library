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
/// Cryptographic Key.
/// </summary>
[IsoId("_oxe5kWpLEeSR-ZWLvO-1dg")]
[DisplayName("Cryptographic Key")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CryptographicKey5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CryptographicKey5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CryptographicKey5( System.String reqIdentification,System.String reqVersion,CryptographicKeyType3Code reqType,ContentInformationType10 reqKeyValue )
    {
        Identification = reqIdentification;
        Version = reqVersion;
        Type = reqType;
        KeyValue = reqKeyValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_o92hoWpLEeSR-ZWLvO-1dg")]
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
    [IsoId("_o92ho2pLEeSR-ZWLvO-1dg")]
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
    [IsoId("_o92hpWpLEeSR-ZWLvO-1dg")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax256Text Version { get; init; } 
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
    [IsoId("_o92hp2pLEeSR-ZWLvO-1dg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CryptographicKeyType3Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CryptographicKeyType3Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKeyType3Code Type { get; init; } 
    #else
    public CryptographicKeyType3Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_o92hqWpLEeSR-ZWLvO-1dg")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = new SimpleValueList<KeyUsage1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _o92hqWpLEeSR-ZWLvO-1dg
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_o92hq2pLEeSR-ZWLvO-1dg")]
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
    [IsoId("_o92hrWpLEeSR-ZWLvO-1dg")]
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
    [IsoId("_o92hr2pLEeSR-ZWLvO-1dg")]
    [DisplayName("Key Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyVal")]
    #endif
    [IsoXmlTag("KeyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType10 KeyValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentInformationType10 KeyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10 KeyValue { get; init; } 
    #else
    public ContentInformationType10 KeyValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
