// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to registration of securities.
/// </summary>
[IsoId("_VwlrITtHEeWRTLSN0i0tng")]
[DisplayName("Registration Parameters")]
public record RegistrationParameters4
{
    /// <summary>
    /// Identification assigned to a deposit.
    /// </summary>
    [IsoId("_WSEAgztHEeWRTLSN0i0tng")]
    [DisplayName("Certification Identification")]
    [IsoXmlTag("CertfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificationIdentification { get; init; }

    /// <summary>
    /// Date/time at which the certificates in the deposit were validated by the agent.
    /// </summary>
    [IsoId("_WSEAiztHEeWRTLSN0i0tng")]
    [DisplayName("Certification Date Time")]
    [IsoXmlTag("CertfctnDtTm")]
    public DateAndDateTimeChoice_? CertificationDateTime { get; init; }

    /// <summary>
    /// Account at the registrar where financial instruments are registered.
    /// </summary>
    [IsoId("_WSEAkztHEeWRTLSN0i0tng")]
    [DisplayName("Registrar Account")]
    [IsoXmlTag("RegarAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrarAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_WSEAmztHEeWRTLSN0i0tng")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SecuritiesCertificate4? CertificateNumber { get; init; }
}
