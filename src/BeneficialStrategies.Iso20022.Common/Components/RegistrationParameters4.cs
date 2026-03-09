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
/// Information related to registration of securities.
/// </summary>
[IsoId("_VwlrITtHEeWRTLSN0i0tng")]
[DisplayName("Registration Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegistrationParameters4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a deposit.
    /// </summary>
    [IsoId("_WSEAgztHEeWRTLSN0i0tng")]
    [DisplayName("Certification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnId")]
    #endif
    [IsoXmlTag("CertfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CertificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationIdentification { get; init; } 
    #else
    public System.String? CertificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the certificates in the deposit were validated by the agent.
    /// </summary>
    [IsoId("_WSEAiztHEeWRTLSN0i0tng")]
    [DisplayName("Certification Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnDtTm")]
    #endif
    [IsoXmlTag("CertfctnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? CertificationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? CertificationDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? CertificationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Account at the registrar where financial instruments are registered.
    /// </summary>
    [IsoId("_WSEAkztHEeWRTLSN0i0tng")]
    [DisplayName("Registrar Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegarAcct")]
    #endif
    [IsoXmlTag("RegarAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RegistrarAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrarAccount { get; init; } 
    #else
    public System.String? RegistrarAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_WSEAmztHEeWRTLSN0i0tng")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCertificate4? CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCertificate4? CertificateNumber { get; init; } 
    #else
    public SecuritiesCertificate4? CertificateNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
