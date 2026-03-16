// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification expressed as a proprietary type and narrative description.
/// </summary>
[IsoId("_fe2HswxeEeuoAcnnpX2x_w")]
[DisplayName("Generic Identification")]
public record GenericIdentification179
{
    /// <summary>
    /// Identification of the lot, according to a data source scheme. Used to indicate which processing to apply to the corresponding market value amount.
    /// </summary>
    [IsoId("_fe2HtQxeEeuoAcnnpX2x_w")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text Identification { get; init; }

    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    [IsoId("_fe2HtAxeEeuoAcnnpX2x_w")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
