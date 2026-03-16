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
[IsoId("_u5SfATbsEead9bDRE_1DAQ")]
[DisplayName("Party Identification")]
public record PartyIdentification113
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_6hU8UjbwEead9bDRE_1DAQ")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification90Choice_ Party { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_6hU8UzbwEead9bDRE_1DAQ")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
