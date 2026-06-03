// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party with the type related to penalties.
/// </summary>
[IsoId("_9_oYmQAUEeqOHNEXayM0Mg")]
[DisplayName("Penalty Party Identification1")]
public record PenaltyPartyIdentification1
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_-EPy0QAUEeqOHNEXayM0Mg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification136 Identification { get; init; }

    /// <summary>
    /// Type of the party.
    /// </summary>
    [IsoId("_-EPy0wAUEeqOHNEXayM0Mg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PenaltyPartyType2Choice_? Type { get; init; }
}
