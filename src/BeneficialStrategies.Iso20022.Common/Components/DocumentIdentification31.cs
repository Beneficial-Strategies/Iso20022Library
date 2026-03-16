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
[IsoId("_e22_UTnXEeWLJsP1cO-amg")]
[DisplayName("Document Identification")]
public record DocumentIdentification31
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_fC53QznXEeWLJsP1cO-amg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Specifies when this document is to be processed relative to another referred document.
    /// </summary>
    [IsoId("_fC53SznXEeWLJsP1cO-amg")]
    [DisplayName("Linkage Type")]
    [IsoXmlTag("LkgTp")]
    public ProcessingPosition7Choice_? LinkageType { get; init; }
}
