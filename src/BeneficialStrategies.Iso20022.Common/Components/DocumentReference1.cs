// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains Document Reference Values provided for this transaction and used for various document processing at the
/// customer site.
/// </summary>
[IsoId("__ljNE_QAEeihCvvpsmGI2w")]
[DisplayName("Document Reference")]
public record DocumentReference1
{
    /// <summary>
    /// Describes the type of document.
    /// </summary>
    [IsoId("__ljNFfQAEeihCvvpsmGI2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Type { get; init; }

    /// <summary>
    /// Reference is a free-form text field containing customer reference information (for example, a document number).
    /// </summary>
    [IsoId("__ljNFPQAEeihCvvpsmGI2w")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Reference { get; init; }
}
