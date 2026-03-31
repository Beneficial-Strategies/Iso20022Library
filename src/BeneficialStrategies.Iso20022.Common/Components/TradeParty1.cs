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
[IsoId("_SkxHpQEcEeCQm6a_G2yO_w_-1189818940")]
[DisplayName("Trade Party")]
public record TradeParty1
{
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_SkxHpgEcEeCQm6a_G2yO_w_586271680")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PartyIdentification45 PartyIdentification { get; init; }

    /// <summary>
    /// Legally constituted organization specified for this trade party.
    /// </summary>
    [IsoId("_SkxHpwEcEeCQm6a_G2yO_w_1704885024")]
    [DisplayName("Legal Organisation")]
    [IsoXmlTag("LglOrg")]
    public LegalOrganisation1? LegalOrganisation { get; init; }

    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    [IsoId("_SkxHqAEcEeCQm6a_G2yO_w_-1057475765")]
    [DisplayName("Tax Party")]
    [IsoXmlTag("TaxPty")]
    public ValueList<TaxParty3> TaxParty { get; init; } = [];
}
