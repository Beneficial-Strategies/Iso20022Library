// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the settlement fails per participant.
/// </summary>
[IsoId("_dhkbUI0UEemUAO64Q252gQ")]
[DisplayName("Settlement Fails Participant")]
public record SettlementFailsParticipant1
{
    /// <summary>
    /// Legal entity identification of the participant in the securities settlement system.
    /// </summary>
    [IsoId("_pLGqQY0UEemUAO64Q252gQ")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier LEI { get; init; }

    /// <summary>
    /// Ranking of the top participants with the highest rate of settlement fails.
    /// </summary>
    [IsoId("_qNCoYY0UEemUAO64Q252gQ")]
    [DisplayName("Rank")]
    [IsoXmlTag("Rank")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public required IsoMax2NumericText Rank { get; init; }

    /// <summary>
    /// Aggregated data of the settlement instructions.
    /// </summary>
    [IsoId("_4yoYwI0UEemUAO64Q252gQ")]
    [DisplayName("Aggregate")]
    [IsoXmlTag("Aggt")]
    public required SettlementTotalData1 Aggregate { get; init; }
}
