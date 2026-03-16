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
[IsoId("_A0iQwNokEeC60axPepSq7g_-1847599416")]
[DisplayName("Registration Parameters")]
public record RegistrationParameters3
{
    /// <summary>
    /// Identification assigned to a deposit.
    /// </summary>
    [IsoId("_A0iQwdokEeC60axPepSq7g_-2139557154")]
    [DisplayName("Certification Identification")]
    [IsoXmlTag("CertfctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificationIdentification { get; init; }

    /// <summary>
    /// Date/time at which the certificates in the deposit were validated by the agent.
    /// </summary>
    [IsoId("_A0iQwtokEeC60axPepSq7g_1450295527")]
    [DisplayName("Certification Date Time")]
    [IsoXmlTag("CertfctnDtTm")]
    public DateAndDateTime1Choice_? CertificationDateTime { get; init; }

    /// <summary>
    /// Account at the registrar where financial instruments are registered.
    /// </summary>
    [IsoId("_A0iQw9okEeC60axPepSq7g_-1612561211")]
    [DisplayName("Registrar Account")]
    [IsoXmlTag("RegarAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegistrarAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_A0iQxNokEeC60axPepSq7g_1724971461")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SecuritiesCertificate3? CertificateNumber { get; init; }
}
