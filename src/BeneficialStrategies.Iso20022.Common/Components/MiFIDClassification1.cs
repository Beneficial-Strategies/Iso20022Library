// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details about the MIFID classification of the account owner.
/// </summary>
[IsoId("_WsmcQxOAEeKjmvxNCObNeQ")]
[DisplayName("Mi FID Classification")]
public record MiFIDClassification1
{
    /// <summary>
    /// MiFID classification of the account owner.
    /// </summary>
    [IsoId("_wcTUoBOAEeKjmvxNCObNeQ")]
    [DisplayName("Classification")]
    [IsoXmlTag("Clssfctn")]
    public required OrderOriginatorEligibility1Code Classification { get; init; }

    /// <summary>
    /// Additional information about the source of classification.
    /// </summary>
    [IsoId("_XomVABOBEeKjmvxNCObNeQ")]
    [DisplayName("Narrative")]
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Narrative { get; init; }
}
