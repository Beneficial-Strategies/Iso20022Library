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
[IsoId("_chT0l5KQEeWHWpTQn1FFVg")]
[DisplayName("Document Identification")]
public record DocumentIdentification37
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_chT0mZKQEeWHWpTQn1FFVg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text Identification { get; init; }

    /// <summary>
    /// Specifies when this document is to be processed relative to another referred document.
    /// </summary>
    [IsoId("_chT0oZKQEeWHWpTQn1FFVg")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition10Choice_? LinkageType { get; init; }
}
