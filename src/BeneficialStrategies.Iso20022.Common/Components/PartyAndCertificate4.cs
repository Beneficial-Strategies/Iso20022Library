// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and related security certificate.
/// </summary>
[IsoId("_DDQThW49EeiU9cctagi5ow")]
[DisplayName("Party And Certificate")]
public record PartyAndCertificate4
{
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_DOvKwW49EeiU9cctagi5ow")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification135 Party { get; init; }

    /// <summary>
    /// Security certificate used to sign electronically.
    /// </summary>
    [IsoId("_DOvKw249EeiU9cctagi5ow")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? Certificate { get; init; }
}
