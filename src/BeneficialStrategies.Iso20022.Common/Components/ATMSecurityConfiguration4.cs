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
/// Configuration of the digital signatures if the security module is able to perform digital signatures with an asymmetric key.
/// </summary>
[IsoId("_u0cgsYr8EeSvuOJS0mmL0g")]
[DisplayName("ATM Security Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMSecurityConfiguration4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Maximum number of certificates in a certificate path, the security module is able to manage.
    /// </summary>
    [IsoId("_HRDZgIr9EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Certificates")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxCerts")]
    #endif
    [IsoXmlTag("MaxCerts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumCertificates { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumCertificates { get; init; } 
    #else
    public System.UInt64? MaximumCertificates { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum number of cosigners, the security module is able to manage in a digital signature.
    /// </summary>
    [IsoId("_LYwOsIr9EeSvuOJS0mmL0g")]
    [DisplayName("Maximum Signatures")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxSgntrs")]
    #endif
    [IsoXmlTag("MaxSgntrs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumSignatures { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumSignatures { get; init; } 
    #else
    public System.UInt64? MaximumSignatures { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature algorithm the security module is able to manage.
    /// </summary>
    [IsoId("_vBzAOYr8EeSvuOJS0mmL0g")]
    [DisplayName("Digital Signature Algorithm")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntrAlgo")]
    #endif
    [IsoXmlTag("DgtlSgntrAlgo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Algorithm14Code? DigitalSignatureAlgorithm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Algorithm14Code? DigitalSignatureAlgorithm { get; init; } 
    #else
    public Algorithm14Code? DigitalSignatureAlgorithm { get; set; } 
    #endif
    
    
    #nullable disable
    
}
