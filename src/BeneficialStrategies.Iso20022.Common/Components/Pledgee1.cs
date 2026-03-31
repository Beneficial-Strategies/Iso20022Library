// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the entity to which the financial instruments are pledged.
/// </summary>
[IsoId("_L4DRE23OEeWiCveyP14Tuw")]
[DisplayName("Pledgee")]
public record Pledgee1
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_L4DRFW3OEeWiCveyP14Tuw")]
    [DisplayName("Pledgee Type And Identification")]
    [IsoXmlTag("PldgeeTpAndId")]
    public PledgeeFormat3Choice_? PledgeeTypeAndIdentification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_L4DRFG3OEeWiCveyP14Tuw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
