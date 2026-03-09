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
/// Content of or reference to the content of a message.
/// </summary>
[IsoId("_jrZ20EXWEeegp_DADCe7HQ")]
[DisplayName("Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Content1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Content1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Content1( System.String reqValue )
    {
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the content of or the reference to the message.
    /// </summary>
    [IsoId("_7RCrYEXWEeegp_DADCe7HQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.Max20KText)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax20KText Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Value { get; init; } 
    #else
    public System.String Value { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the content of or the reference to the message.
    /// </summary>
    [IsoId("_Y50HEEXXEeegp_DADCe7HQ")]
    [DisplayName("Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgntr")]
    #endif
    [IsoXmlTag("Sgntr")]
    [IsoSimpleType(IsoSimpleType.Max140Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Binary? Signature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? Signature { get; init; } 
    #else
    public System.Byte[]? Signature { get; set; } 
    #endif
    
    /// <summary>
    /// Signing certificate identification.
    /// </summary>
    [IsoId("_lPoNMEXXEeegp_DADCe7HQ")]
    [DisplayName("Certificate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertId")]
    #endif
    [IsoXmlTag("CertId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CertificateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateIdentification { get; init; } 
    #else
    public System.String? CertificateIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
