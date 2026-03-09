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
/// Certification request PKCS#10 (Public Key Certificate Standard 10) for creation or renewal of an X.509 certificate.
/// </summary>
[IsoId("_ruEwkI4REeW6h7rGyYlyTg")]
[DisplayName("Certification Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificationRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CertificationRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CertificationRequest1( CertificationRequest2 reqCertificateRequestInformation )
    {
        CertificateRequestInformation = reqCertificateRequestInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information of the certificate to create.
    /// </summary>
    [IsoId("_VYZSkI4SEeW6h7rGyYlyTg")]
    [DisplayName("Certificate Request Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertReqInf")]
    #endif
    [IsoXmlTag("CertReqInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CertificationRequest2 CertificateRequestInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CertificationRequest2 CertificateRequestInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificationRequest2 CertificateRequestInformation { get; init; } 
    #else
    public CertificationRequest2 CertificateRequestInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the key.
    /// </summary>
    [IsoId("_6_1qcI4REeW6h7rGyYlyTg")]
    [DisplayName("Key Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyId")]
    #endif
    [IsoXmlTag("KeyId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? KeyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? KeyIdentification { get; init; } 
    #else
    public System.String? KeyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Version of the key.
    /// </summary>
    [IsoId("_dWxMcI4UEeW6h7rGyYlyTg")]
    [DisplayName("Key Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="KeyVrsn")]
    #endif
    [IsoXmlTag("KeyVrsn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? KeyVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? KeyVersion { get; init; } 
    #else
    public System.String? KeyVersion { get; set; } 
    #endif
    
    
    #nullable disable
    
}
