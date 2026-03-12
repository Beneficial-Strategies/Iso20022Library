// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to registration of securities.
/// </summary>
[IsoId("_vXd56c3zEee5nJBZsW8MFQ")]
[DisplayName("Registration Parameters")]
public partial record RegistrationParameters7
{
    #nullable enable
    
    /// <summary>
    /// Identification assigned to a deposit.
    /// </summary>
    [IsoId("_vXd5683zEee5nJBZsW8MFQ")]
    [DisplayName("Certification Identification")]
    [IsoXmlTag("CertfctnId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? CertificationIdentification { get; init; } 
    
    /// <summary>
    /// Date/time at which the certificates in the deposit were validated by the agent.
    /// </summary>
    [IsoId("_vXd5883zEee5nJBZsW8MFQ")]
    [DisplayName("Certification Date Time")]
    [IsoXmlTag("CertfctnDtTm")]
    public DateAndDateTime2Choice_? CertificationDateTime { get; init; } 
    
    /// <summary>
    /// Account at the registrar where financial instruments are registered.
    /// </summary>
    [IsoId("_vXd5-83zEee5nJBZsW8MFQ")]
    [DisplayName("Registrar Account")]
    [IsoXmlTag("RegarAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? RegistrarAccount { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_vXd6A83zEee5nJBZsW8MFQ")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SecuritiesCertificate5? CertificateNumber { get; init; } 
    
    
    #nullable disable
    
}
