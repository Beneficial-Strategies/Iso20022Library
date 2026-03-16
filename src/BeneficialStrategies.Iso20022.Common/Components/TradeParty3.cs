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
[IsoId("_kTob4cNREeWGDrnsYu2p6g")]
[DisplayName("Trade Party")]
public record TradeParty3
{
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_kf-10cNREeWGDrnsYu2p6g")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification112 PartyIdentification { get; init; }

    /// <summary>
    /// Legally constituted organization specified for this trade party.
    /// </summary>
    [IsoId("_kf-108NREeWGDrnsYu2p6g")]
    [DisplayName("Legal Organisation")]
    [IsoXmlTag("LglOrg")]
    public LegalOrganisation1? LegalOrganisation { get; init; }

    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_kf-11cNREeWGDrnsYu2p6g")]
    [DisplayName("Tax Party")]
    [IsoXmlTag("TaxPty")]
    public ValueList<TaxParty3> TaxParty { get; init; } = [];
}
