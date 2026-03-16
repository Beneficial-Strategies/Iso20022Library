// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a person or an organisation.
/// </summary>
[IsoId("_HQzfkCFjEeW9XJWqfgXIIA")]
[DisplayName("Party Identification")]
public record PartyIdentification95
{
    /// <summary>
    /// Identifier for an organisation that is allocated by an institution.
    /// </summary>
    [IsoId("_XY16ISFjEeW9XJWqfgXIIA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification70Choice_? Identification { get; init; }

    /// <summary>
    /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 &quot;Financial Services - Legal Entity Identifier (LEI)&quot;.
    /// </summary>
    [IsoId("_w3KuoSFjEeW9XJWqfgXIIA")]
    [DisplayName("Legal Entity Identifier")]
    [IsoXmlTag("LglNttyIdr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LegalEntityIdentifier { get; init; }
}
