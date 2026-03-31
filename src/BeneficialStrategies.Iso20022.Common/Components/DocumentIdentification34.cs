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
[IsoId("_celQqZKQEeWHWpTQn1FFVg")]
[DisplayName("Document Identification")]
public record DocumentIdentification34
{
    /// <summary>
    /// Unique identifier of the document (message) assigned either by the account servicer or the account owner.
    /// </summary>
    [IsoId("_celQq5KQEeWHWpTQn1FFVg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DocumentIdentification4Choice_ Identification { get; init; }

    /// <summary>
    /// Identification of the type of document.
    /// </summary>
    [IsoId("_celQs5KQEeWHWpTQn1FFVg")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public DocumentNumber6Choice_? DocumentNumber { get; init; }
}
