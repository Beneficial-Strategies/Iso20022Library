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
/// Certificate issuer name and serial number (see X.509).
/// </summary>
[IsoId("_SxIvsQEcEeCQm6a_G2yO_w_-65882528")]
[DisplayName("Issuer And Serial Number")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IssuerAndSerialNumber1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IssuerAndSerialNumber1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IssuerAndSerialNumber1( CertificateIssuer1 reqIssuer,System.Byte[] reqSerialNumber )
    {
        Issuer = reqIssuer;
        SerialNumber = reqSerialNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Certificate issuer name (see X.509).
    /// </summary>
    [IsoId("_SxIvsgEcEeCQm6a_G2yO_w_1368507280")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CertificateIssuer1 Issuer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CertificateIssuer1 Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateIssuer1 Issuer { get; init; } 
    #else
    public CertificateIssuer1 Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Certificate serial number (see X.509).
    /// </summary>
    [IsoId("_SxIvswEcEeCQm6a_G2yO_w_683840175")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Binary SerialNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Byte[] SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[] SerialNumber { get; init; } 
    #else
    public System.Byte[] SerialNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
