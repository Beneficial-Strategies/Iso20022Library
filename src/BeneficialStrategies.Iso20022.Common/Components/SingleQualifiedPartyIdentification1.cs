// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines an identifier for a party relative to another party using an identifier of another party followed by a local identifier issued by the other party.
/// It is assumed that customers of an identifiable party can be referenced by an identifier relative to that party. The identification of the party together with the relative identifier identifies the customer.
/// Such references can occur in sequence. The last occurrence of RelativeIdentifier is the local identifier at the party recursively defined by the PrefixParty and all preceding occurrences of RelativeIdentifier.
/// Technical note: The sequence of relative identifiers is used to avoid a recursive definition in the catalogue.
/// </summary>
[IsoId("_OTgzMjUx-AOSNFX-8224494")]
[DisplayName("Single Qualified Party Identification")]
public record SingleQualifiedPartyIdentification1
{
    /// <summary>
    /// Party identification recognisable by parties in the trade.
    /// </summary>
    [IsoId("_OTgzMjUy-AOSNFX-8224494")]
    [DisplayName("Base Party")]
    [IsoXmlTag("BasePty")]
    public required TradeParty1 BaseParty { get; init; }

    /// <summary>
    /// Identifies a party, each identifier is recursively defined relative to the party identified by the base party and the preceding part of the list.
    /// </summary>
    [IsoId("_OTgzMjUz-AOSNFX-8224494")]
    [DisplayName("Relative Identifier")]
    [IsoXmlTag("RltvIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> RelativeIdentifier { get; init; } = [];
}
