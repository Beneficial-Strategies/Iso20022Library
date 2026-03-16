// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a document as well as the document number.
/// </summary>
[IsoId("_EsxJoTnaEeWLJsP1cO-amg")]
[DisplayName("Document Identification")]
public record DocumentIdentification33
{
    /// <summary>
    /// Unique identifier of the document (message) assigned either by the account servicer or the account owner.
    /// </summary>
    [IsoId("_E5kPgTnaEeWLJsP1cO-amg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Identification of the type of document.
    /// </summary>
    [IsoId("_E5kPiTnaEeWLJsP1cO-amg")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public DocumentNumber5Choice_? DocumentNumber { get; init; }
}
