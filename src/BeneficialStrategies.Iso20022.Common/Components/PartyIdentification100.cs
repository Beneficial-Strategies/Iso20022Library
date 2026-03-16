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
[IsoId("_QgqFw2wfEeWLq_lbZ2Mhyw")]
[DisplayName("Party Identification")]
public record PartyIdentification100
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_QgqFxGwfEeWLq_lbZ2Mhyw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification71Choice_ Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_QgqFxWwfEeWLq_lbZ2Mhyw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
