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
[IsoId("_SlECkAEcEeCQm6a_G2yO_w_2075753365")]
[DisplayName("Generic Identification")]
public record GenericIdentification31
{
    /// <summary>
    /// Identification of the entity.
    /// </summary>
    [IsoId("_SlECkQEcEeCQm6a_G2yO_w_1961914299")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Type of identified entity.
    /// </summary>
    [IsoId("_SlECkgEcEeCQm6a_G2yO_w_964841946")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PartyType3Code Type { get; init; }

    /// <summary>
    /// Entity assigning the identification (for example merchant, acceptor, acquirer, or tax authority).
    /// </summary>
    [IsoId("_SlECkwEcEeCQm6a_G2yO_w_-1719697229")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyType4Code? Issuer { get; init; }

    /// <summary>
    /// Name of the entity.
    /// </summary>
    [IsoId("_SlEClAEcEeCQm6a_G2yO_w_1578197714")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }
}
