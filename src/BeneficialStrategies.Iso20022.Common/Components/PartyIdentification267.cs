// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of identification of a party. The party can be identified by providing a BIC or a proprietary code.
/// Optionally, the client account number can also be provided.
/// </summary>
[IsoId("_6sPMvwauEe2phaVG0lYKTw")]
[DisplayName("Party Identification")]
public record PartyIdentification267
{
    /// <summary>
    /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_6_A-oQauEe2phaVG0lYKTw")]
    [DisplayName("BIC")]
    [IsoXmlTag("BIC")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    public required IsoAnyBICDec2014Identifier BIC { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_6_A-owauEe2phaVG0lYKTw")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public required GenericIdentification36 ProprietaryIdentification { get; init; }

    /// <summary>
    /// Identification of a party with its name and address in free text.
    /// </summary>
    [IsoId("_6_A-pQauEe2phaVG0lYKTw")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public NameAndAddress13? NameAndAddress { get; init; }
}
