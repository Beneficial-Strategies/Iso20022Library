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
[IsoId("5ae28cf6-4a39-415e-af5b-46f8d4a99bb2")]
[DisplayName("Party Identification339")]
public record PartyIdentification339
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("c61857a7-d86c-4cd0-872e-3b0bb3b16bb4")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification262Choice_ Party { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("58b84cc6-3138-4e6a-bde1-e1794402b211")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }
}
