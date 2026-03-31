// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity involved in an activity.
/// </summary>
[IsoId("_H8I8YQavEe2phaVG0lYKTw")]
[DisplayName("Party Identification")]
public record PartyIdentification268
{
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [IsoId("_IP93VQavEe2phaVG0lYKTw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification244Choice_ Identification { get; init; }

    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_IP93XQavEe2phaVG0lYKTw")]
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public AlternatePartyIdentification8? AlternateIdentification { get; init; }

    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_IP93ZQavEe2phaVG0lYKTw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public PartyTextInformation1? AdditionalInformation { get; init; }
}
