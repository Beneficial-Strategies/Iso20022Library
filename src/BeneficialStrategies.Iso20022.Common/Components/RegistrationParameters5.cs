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
[IsoId("_6Szd8ZNLEeWGlc8L7oPDIg")]
[DisplayName("Registration Parameters")]
public record RegistrationParameters5
{
    /// <summary>
    /// Identification assigned to a deposit.
    /// </summary>
    [IsoId("_6Szd85NLEeWGlc8L7oPDIg")]
    [DisplayName("Certification Identification")]
    [IsoXmlTag("CertfctnId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? CertificationIdentification { get; init; }

    /// <summary>
    /// Date/time at which the certificates in the deposit were validated by the agent.
    /// </summary>
    [IsoId("_6Szd-5NLEeWGlc8L7oPDIg")]
    [DisplayName("Certification Date Time")]
    [IsoXmlTag("CertfctnDtTm")]
    public DateAndDateTimeChoice_? CertificationDateTime { get; init; }

    /// <summary>
    /// Account at the registrar where financial instruments are registered.
    /// </summary>
    [IsoId("_6SzeA5NLEeWGlc8L7oPDIg")]
    [DisplayName("Registrar Account")]
    [IsoXmlTag("RegarAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? RegistrarAccount { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_6SzeC5NLEeWGlc8L7oPDIg")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public ValueList<SecuritiesCertificate5> CertificateNumber { get; init; } = [];
}
