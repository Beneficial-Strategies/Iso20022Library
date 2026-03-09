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
/// Information of the certificate to create.
/// </summary>
[IsoId("_Bv1XkY4SEeW6h7rGyYlyTg")]
[DisplayName("Certification Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CertificationRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CertificationRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CertificationRequest2( PublicRSAKey2 reqSubjectPublicKeyInformation )
    {
        SubjectPublicKeyInformation = reqSubjectPublicKeyInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Version of the certificate request information data structure.
    /// </summary>
    [IsoId("_B8DOoY4SEeW6h7rGyYlyTg")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Version { get; init; } 
    #else
    public System.UInt64? Version { get; set; } 
    #endif
    
    /// <summary>
    /// Distinguished name of the certificate subject, the entity whose public key is to be certified.
    /// </summary>
    [IsoId("_jCXvQI4SEeW6h7rGyYlyTg")]
    [DisplayName("Subject Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbjtNm")]
    #endif
    [IsoXmlTag("SbjtNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CertificateIssuer1? SubjectName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CertificateIssuer1? SubjectName { get; init; } 
    #else
    public CertificateIssuer1? SubjectName { get; set; } 
    #endif
    
    /// <summary>
    /// Information about the public key being certified.
    /// </summary>
    [IsoId("_I9cYUI4TEeW6h7rGyYlyTg")]
    [DisplayName("Subject Public Key Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbjtPblcKeyInf")]
    #endif
    [IsoXmlTag("SbjtPblcKeyInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PublicRSAKey2 SubjectPublicKeyInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PublicRSAKey2 SubjectPublicKeyInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PublicRSAKey2 SubjectPublicKeyInformation { get; init; } 
    #else
    public PublicRSAKey2 SubjectPublicKeyInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Attribute of the certificate service to be put in the certificate extensions, or to be used for the request.
    /// </summary>
    [IsoId("_ECnAkI4UEeW6h7rGyYlyTg")]
    [DisplayName("Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attr")]
    #endif
    [IsoXmlTag("Attr")]
    public ValueList<RelativeDistinguishedName2> Attribute { get; init; } = new ValueList<RelativeDistinguishedName2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _ECnAkI4UEeW6h7rGyYlyTg
    
    
    #nullable disable
    
}
