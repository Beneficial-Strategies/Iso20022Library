// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity.
/// </summary>
[IsoId("_BF6eIRvQEey2RdTw-AkXzg")]
[DisplayName("Generic Identification")]
public record GenericIdentification183
{
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_BM7FERvQEey2RdTw-AkXzg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_BM7FExvQEey2RdTw-AkXzg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType17Code? Type { get; init; }

    /// <summary>
    /// Other type of identification.
    /// </summary>
    [IsoId("_BM7FFRvQEey2RdTw-AkXzg")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Entity type in charge of assigning an identification.
    /// </summary>
    [IsoId("_BM7FFxvQEey2RdTw-AkXzg")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public PartyType18Code? Assigner { get; init; }

    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_BM7FGRvQEey2RdTw-AkXzg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; }

    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_BM7FGxvQEey2RdTw-AkXzg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }
}
