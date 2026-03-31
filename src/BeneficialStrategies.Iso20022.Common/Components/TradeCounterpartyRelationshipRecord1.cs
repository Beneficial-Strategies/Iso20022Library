// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the relationship record between two parties.
/// </summary>
[IsoId("_XVpN0CR7Ee2VuKUpJ7HXPg")]
[DisplayName("Trade Counterparty Relationship Record")]
public record TradeCounterpartyRelationshipRecord1
{
    /// <summary>
    /// Specifies type of counterparty at the start of a directional relationship.
    /// </summary>
    [IsoId("_iEevECR7Ee2VuKUpJ7HXPg")]
    [DisplayName("Start Relationship Party")]
    [IsoXmlTag("StartRltshPty")]
    public required TradeCounterpartyType1Code StartRelationshipParty { get; init; }

    /// <summary>
    /// Specifies type of counterparty at the end of a directional relationship.
    /// </summary>
    [IsoId("_ixzIECR7Ee2VuKUpJ7HXPg")]
    [DisplayName("End Relationship Party")]
    [IsoXmlTag("EndRltshPty")]
    public required TradeCounterpartyType1Code EndRelationshipParty { get; init; }

    /// <summary>
    /// Type of relationship between two parties.
    /// Usage: RelationshipType is always in the direction of the StartRelationshipParty to EndRelationshipParty.
    /// </summary>
    [IsoId("_jcbZcCR7Ee2VuKUpJ7HXPg")]
    [DisplayName("Relationship Type")]
    [IsoXmlTag("RltshTp")]
    public required TradeCounterpartyRelationship1Choice_ RelationshipType { get; init; }

    /// <summary>
    /// Provides description of other type of relationship between two parties.
    /// Usage: Description is to be used only when RelationshipType is not precisely indicating the type of relationship between parties to the transaction.
    /// </summary>
    [IsoId("_tdQlMCR7Ee2VuKUpJ7HXPg")]
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? Description { get; init; }
}
