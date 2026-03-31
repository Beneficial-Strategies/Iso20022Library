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
[IsoId("_Z0x6xffVEeiNZp_PtLohLw")]
[DisplayName("Party Identification")]
public record PartyIdentification157
{
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_Z0x6x_fVEeiNZp_PtLohLw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification137Choice_ Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_Z0x6yffVEeiNZp_PtLohLw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
