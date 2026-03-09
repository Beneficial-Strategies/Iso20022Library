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
/// Transport key or key encryption key (KEK) identification for the recipient.
/// </summary>
[IsoId("_SxIvtAEcEeCQm6a_G2yO_w_1837772326")]
[DisplayName("Certificate Identifier")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificateIdentifier1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CertificateIdentifier1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CertificateIdentifier1( IssuerAndSerialNumber1 reqIssuerAndSerialNumber )
    {
        IssuerAndSerialNumber = reqIssuerAndSerialNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Certificate issuer name and serial number (see X.509).
    /// </summary>
    [IsoId("_SxIvtQEcEeCQm6a_G2yO_w_942906832")]
    [DisplayName("Issuer And Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrAndSrlNb")]
    #endif
    [IsoXmlTag("IssrAndSrlNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IssuerAndSerialNumber1 IssuerAndSerialNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required IssuerAndSerialNumber1 IssuerAndSerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IssuerAndSerialNumber1 IssuerAndSerialNumber { get; init; } 
    #else
    public IssuerAndSerialNumber1 IssuerAndSerialNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
