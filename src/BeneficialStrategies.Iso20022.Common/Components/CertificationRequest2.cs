// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information of the certificate to create.
/// </summary>
[IsoId("_Bv1XkY4SEeW6h7rGyYlyTg")]
[DisplayName("Certification Request")]
public record CertificationRequest2
{
    /// <summary>
    /// Version of the certificate request information data structure.
    /// </summary>
    [IsoId("_B8DOoY4SEeW6h7rGyYlyTg")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? Version { get; init; }

    /// <summary>
    /// Distinguished name of the certificate subject, the entity whose public key is to be certified.
    /// </summary>
    [IsoId("_jCXvQI4SEeW6h7rGyYlyTg")]
    [DisplayName("Subject Name")]
    [IsoXmlTag("SbjtNm")]
    public CertificateIssuer1? SubjectName { get; init; }

    /// <summary>
    /// Information about the public key being certified.
    /// </summary>
    [IsoId("_I9cYUI4TEeW6h7rGyYlyTg")]
    [DisplayName("Subject Public Key Information")]
    [IsoXmlTag("SbjtPblcKeyInf")]
    public required PublicRSAKey2 SubjectPublicKeyInformation { get; init; }

    /// <summary>
    /// Attribute of the certificate service to be put in the certificate extensions, or to be used for the request.
    /// </summary>
    [IsoId("_ECnAkI4UEeW6h7rGyYlyTg")]
    [DisplayName("Attribute")]
    [IsoXmlTag("Attr")]
    public ValueList<RelativeDistinguishedName2> Attribute { get; init; } = [];
    // ID for the above is _ECnAkI4UEeW6h7rGyYlyTg
}
