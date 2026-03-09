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
[IsoId("_vXd56c3zEee5nJBZsW8MFQ")]
[DisplayName("Registration Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RegistrationParameters7
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
    [IsoId("_vXd5683zEee5nJBZsW8MFQ")]
    [DisplayName("Certification Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnId")]
    #endif
    [IsoXmlTag("CertfctnId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? CertificationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationIdentification { get; init; } 
    #else
    public System.String? CertificationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the certificates in the deposit were validated by the agent.
    /// </summary>
    [IsoId("_vXd5883zEee5nJBZsW8MFQ")]
    [DisplayName("Certification Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnDtTm")]
    #endif
    [IsoXmlTag("CertfctnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? CertificationDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? CertificationDateTime { get; init; } 
    #else
    public DateAndDateTime2Choice_? CertificationDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Account at the registrar where financial instruments are registered.
    /// </summary>
    [IsoId("_vXd5-83zEee5nJBZsW8MFQ")]
    [DisplayName("Registrar Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegarAcct")]
    #endif
    [IsoXmlTag("RegarAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax35Text? RegistrarAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RegistrarAccount { get; init; } 
    #else
    public System.String? RegistrarAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_vXd6A83zEee5nJBZsW8MFQ")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesCertificate5? CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesCertificate5? CertificateNumber { get; init; } 
    #else
    public SecuritiesCertificate5? CertificateNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
