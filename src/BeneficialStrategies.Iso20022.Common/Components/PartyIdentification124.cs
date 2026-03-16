// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_Ol1A0YipEeefvMoXmllHqg")]
[DisplayName("Party Identification")]
public record PartyIdentification124
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_O1TAM4ipEeefvMoXmllHqg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification119Choice_ Party { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_O1TANYipEeefvMoXmllHqg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
