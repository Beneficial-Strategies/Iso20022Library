// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of infrastructure which may be a component of a clearing house and which facilitates clearing and settlement for its members by standing between the buyer and the seller. It may net transactions and it substitutes itself as settlement counterparty for each position.
/// </summary>
[IsoId("_GVozg2wwEeWLq_lbZ2Mhyw")]
[DisplayName("Place Of Clearing Identification")]
public record PlaceOfClearingIdentification1
{
    /// <summary>
    /// Unique identification of the place of clearing.
    /// </summary>
    [IsoId("_GVozhGwwEeWLq_lbZ2Mhyw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? Identification { get; init; }

    /// <summary>
    /// Legal entity identification as an alternate identification for a place of clearing.
    /// </summary>
    [IsoId("_GVozhWwwEeWLq_lbZ2Mhyw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; }
}
