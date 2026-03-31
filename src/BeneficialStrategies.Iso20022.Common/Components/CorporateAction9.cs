// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// An event determined by a corporation&apos;s board of directors, that changes the existing corporate capital structure or financial condition.
/// </summary>
[IsoId("_t20OQVkyEeGeoaLUQk__nA_-1416100338")]
[DisplayName("Corporate Action")]
public record CorporateAction9
{
    /// <summary>
    /// Type of corporate action event, in a free-text format.
    /// </summary>
    [IsoId("_t20OQlkyEeGeoaLUQk__nA_1767955539")]
    [DisplayName("Event Type")]
    [IsoXmlTag("EvtTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EventType { get; init; }

    /// <summary>
    /// Identification of a corporate action assigned by an official central body/entity within a given market.
    /// </summary>
    [IsoId("_t20OQ1kyEeGeoaLUQk__nA_2048814500")]
    [DisplayName("Event Identification")]
    [IsoXmlTag("EvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text EventIdentification { get; init; }
}
