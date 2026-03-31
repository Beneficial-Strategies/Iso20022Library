// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the party.
/// </summary>
[IsoId("_LiMjcZjcEeWn2ur3BXxtdg")]
[DisplayName("Party Identification")]
public record PartyIdentification110
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_Lxqi0ZjcEeWn2ur3BXxtdg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification115Choice_ Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_Lxqi05jcEeWn2ur3BXxtdg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
