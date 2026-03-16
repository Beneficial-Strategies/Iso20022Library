// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document and type of link.
/// </summary>
[IsoId("_VyeOk5qLEeWcAIE4lEkF_Q")]
[DisplayName("Document Identification")]
public record DocumentIdentification49
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_VyeOlZqLEeWcAIE4lEkF_Q")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text Identification { get; init; }

    /// <summary>
    /// Specifies when this document is to be processed relative to an other referred document.
    /// </summary>
    [IsoId("_VyeOnZqLEeWcAIE4lEkF_Q")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition22Choice_? LinkageType { get; init; }
}
