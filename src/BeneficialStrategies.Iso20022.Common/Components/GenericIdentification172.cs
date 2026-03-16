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
[IsoId("_PYrBcUqMEeenp6hmNprBHg")]
[DisplayName("Generic Identification")]
public record GenericIdentification172
{
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_PizN0UqMEeenp6hmNprBHg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_PizN00qMEeenp6hmNprBHg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PartyType17Code? Type { get; init; }

    /// <summary>
    /// Other type of identification.
    /// </summary>
    [IsoId("_hr120EqMEeenp6hmNprBHg")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; }

    /// <summary>
    /// Entity type in charge of assigning an identification.
    /// </summary>
    [IsoId("_d1-GEMsZEeizUq4cFQ71-Q")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public PartyType18Code? Assigner { get; init; }

    /// <summary>
    /// Country of the entity (ISO 3166-1 alpha-2 or alpha-3).
    /// </summary>
    [IsoId("_PizN10qMEeenp6hmNprBHg")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? Country { get; init; }

    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_PizN2UqMEeenp6hmNprBHg")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }
}
