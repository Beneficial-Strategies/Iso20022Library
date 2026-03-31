// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an entity involved in a trade activity.
/// </summary>
[IsoId("_N3SQQeWlEeevU7McUP3D1w")]
[DisplayName("Trade Party")]
public record TradeParty4
{
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_OAVekeWlEeevU7McUP3D1w")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification129 PartyIdentification { get; init; }

    /// <summary>
    /// Legally constituted organization specified for this trade party.
    /// </summary>
    [IsoId("_OAVek-WlEeevU7McUP3D1w")]
    [DisplayName("Legal Organisation")]
    [IsoXmlTag("LglOrg")]
    public LegalOrganisation1? LegalOrganisation { get; init; }

    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_OAVeleWlEeevU7McUP3D1w")]
    [DisplayName("Tax Party")]
    [IsoXmlTag("TaxPty")]
    public ValueList<TaxParty3> TaxParty { get; init; } = [];
}
