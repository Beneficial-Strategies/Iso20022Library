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
[IsoId("_5XouIQ0XEeqUVL7sB4m7NA")]
[DisplayName("Cryptographic Key")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CryptographicKey14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CryptographicKey14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CryptographicKey14( System.String reqIdentification,System.String reqVersion )
    {
        Identification = reqIdentification;
        Version = reqVersion;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [IsoId("_5iky0Q0XEeqUVL7sB4m7NA")]
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
    [IsoId("_5iky0w0XEeqUVL7sB4m7NA")]
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
    /// Name of the Cryptographic Element.
    /// </summary>
    [IsoId("_LbkNoA0YEeqUVL7sB4m7NA")]
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
    /// Identification of the set of security elements to which this element belongs.
    /// </summary>
    [IsoId("_UN93YA0YEeqUVL7sB4m7NA")]
    [DisplayName("Security Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyPrfl")]
    #endif
    [IsoXmlTag("SctyPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecurityProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityProfile { get; init; } 
    #else
    public System.String? SecurityProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Hierarchical identification of a key inside all the key system. It is composed of all item numbers of the upper level components, separated by the &apos;.&apos; character, ended by the item number of the current component.
    /// </summary>
    [IsoId("_ZLzqYA0YEeqUVL7sB4m7NA")]
    [DisplayName("Item Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ItmNb")]
    #endif
    [IsoXmlTag("ItmNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ItemNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ItemNumber { get; init; } 
    #else
    public System.String? ItemNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [IsoId("_5iky1Q0XEeqUVL7sB4m7NA")]
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
    [IsoId("_5iky1w0XEeqUVL7sB4m7NA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CryptographicKeyType3Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CryptographicKeyType3Code? Type { get; init; } 
    #else
    public CryptographicKeyType3Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [IsoId("_5iky2Q0XEeqUVL7sB4m7NA")]
    [DisplayName("Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fctn")]
    #endif
    [IsoXmlTag("Fctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public KeyUsage1Code? Function { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public KeyUsage1Code? Function { get; init; } 
    #else
    public KeyUsage1Code? Function { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [IsoId("_5iky2w0XEeqUVL7sB4m7NA")]
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
    [IsoId("_5iky3Q0XEeqUVL7sB4m7NA")]
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
    [IsoId("_5iky3w0XEeqUVL7sB4m7NA")]
    [DisplayName("Key Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyVal")]
    #endif
    [IsoXmlTag("KeyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType23? KeyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType23? KeyValue { get; init; } 
    #else
    public ContentInformationType23? KeyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Value for checking a cryptographic key security parameter.
    /// </summary>
    [IsoId("_5iky4Q0XEeqUVL7sB4m7NA")]
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
    /// Additional Information needed by the receiver to securely process the management of the security element.
    /// </summary>
    [IsoId("_5iky4w0XEeqUVL7sB4m7NA")]
    [DisplayName("Additional Management Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlMgmtInf")]
    #endif
    [IsoXmlTag("AddtlMgmtInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericInformation1? AdditionalManagementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericInformation1? AdditionalManagementInformation { get; init; } 
    #else
    public GenericInformation1? AdditionalManagementInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
