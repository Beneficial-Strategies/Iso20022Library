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
/// Cryptographic Key component.
/// </summary>
[IsoId("_2iPFcYtBEeSxlKlAGYErFg")]
[DisplayName("Cryptographic Key")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CryptographicKey7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CryptographicKey7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CryptographicKey7( System.String reqVersion,CryptographicKeyType3Code reqType,ATMStatus3Code reqCurrentStatus )
    {
        Version = reqVersion;
        Type = reqType;
        CurrentStatus = reqCurrentStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [IsoId("_2vMjYYtBEeSxlKlAGYErFg")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_2vMjY4tBEeSxlKlAGYErFg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the security domain.
    /// </summary>
    [IsoId("_R55aIItCEeSxlKlAGYErFg")]
    [DisplayName("Security Domain Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyDomnId")]
    #endif
    [IsoXmlTag("SctyDomnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecurityDomainIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityDomainIdentification { get; init; } 
    #else
    public System.String? SecurityDomainIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional identification of the key, for instance to derive the key.
    /// </summary>
    [IsoId("_lr16oItCEeSxlKlAGYErFg")]
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
    [IsoId("_2vMjZYtBEeSxlKlAGYErFg")]
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
    /// Sequence counter of the cryptographic key.
    /// </summary>
    [IsoId("_K6YHoOgmEeSbwP3G-MV9YA")]
    [DisplayName("Sequence Counter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqCntr")]
    #endif
    [IsoXmlTag("SeqCntr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SequenceCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SequenceCounter { get; init; } 
    #else
    public System.UInt64? SequenceCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [IsoId("_2vMjZ4tBEeSxlKlAGYErFg")]
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
    [IsoId("_2vMjaYtBEeSxlKlAGYErFg")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    public SimpleValueList<KeyUsage1Code> Function { get; init; } = new SimpleValueList<KeyUsage1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _2vMjaYtBEeSxlKlAGYErFg
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_2vMja4tBEeSxlKlAGYErFg")]
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
    [IsoId("_2vMjbYtBEeSxlKlAGYErFg")]
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
    /// Value for checking a cryptographic key.
    /// </summary>
    [IsoId("_UOQ0AItDEeSxlKlAGYErFg")]
    [DisplayName("Key Check Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyChckVal")]
    #endif
    [IsoXmlTag("KeyChckVal")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Binary? KeyCheckValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? KeyCheckValue { get; init; } 
    #else
    public System.Byte[]? KeyCheckValue { get; set; } 
    #endif
    
    /// <summary>
    /// Current status of the key.
    /// </summary>
    [IsoId("_CXQWMItDEeSxlKlAGYErFg")]
    [DisplayName("Current Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSts")]
    #endif
    [IsoXmlTag("CurSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMStatus3Code CurrentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMStatus3Code CurrentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMStatus3Code CurrentStatus { get; init; } 
    #else
    public ATMStatus3Code CurrentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for which the key has been stopped.
    /// </summary>
    [IsoId("_3IPqoItDEeSxlKlAGYErFg")]
    [DisplayName("Failure Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FailrRsn")]
    #endif
    [IsoXmlTag("FailrRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FailureReason6Code? FailureReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FailureReason6Code? FailureReason { get; init; } 
    #else
    public FailureReason6Code? FailureReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
