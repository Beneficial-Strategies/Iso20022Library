// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity involved in an activity.
/// </summary>
[IsoId("_6FVC5ZNLEeWGlc8L7oPDIg")]
[DisplayName("Party Identification")]
public record PartyIdentification108
{
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_6FVC55NLEeWGlc8L7oPDIg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification58Choice_ Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_6FVC75NLEeWGlc8L7oPDIg")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    [IsoId("_6FVC8ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; }
}
