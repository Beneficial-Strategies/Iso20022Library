// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines a signing party and a digital signature made by this party.
/// </summary>
[IsoId("_OTgzMjI3-AOSNFX-8224493")]
[DisplayName("Qualified Party And XML Signature")]
public record QualifiedPartyAndXMLSignature1
{
    /// <summary>
    /// Identification of the signing party.
    /// </summary>
    [IsoId("_OTgzMjc0-AOSNFX-8224496")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public QualifiedPartyIdentification1? Party { get; init; }

    /// <summary>
    /// Digital signature in XML-DSIG format and reference to signing party.
    /// </summary>
    [IsoId("_OTgzMjc2-AOSNFX-8224496")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public required SignatureEnvelope Signature { get; init; }
}
