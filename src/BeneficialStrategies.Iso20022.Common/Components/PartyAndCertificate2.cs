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
[IsoId("_5Ty4AQ4VEeKGXqvMN6jpiw")]
[DisplayName("Party And Certificate")]
public record PartyAndCertificate2
{
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_5pjFkQ4VEeKGXqvMN6jpiw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification43 Party { get; init; }

    /// <summary>
    /// Security certificate used to sign electronically.
    /// </summary>
    [IsoId("_5pjFlQ4VEeKGXqvMN6jpiw")]
    [DisplayName("Certificate")]
    [IsoXmlTag("Cert")]
    [IsoSimpleType(IsoSimpleType.Max10KBinary)]
    public IsoMax10KBinary? Certificate { get; init; }
}
