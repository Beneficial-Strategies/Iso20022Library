// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_Q_AvW3R1EeiH1ZOt2UD8vQ")]
[DisplayName("Party And Signature")]
public record PartyAndSignature3
{
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_RJI7sXR1EeiH1ZOt2UD8vQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification135 Party { get; init; }

    /// <summary>
    /// Signature of a party.
    /// </summary>
    [IsoId("_RJI7s3R1EeiH1ZOt2UD8vQ")]
    [DisplayName("Signature")]
    [IsoXmlTag("Sgntr")]
    public required SkipPayload Signature { get; init; }
}
