// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification.
/// </summary>
[IsoId("_RXpteNp-Ed-ak6NoX_4Aeg_66239534")]
[DisplayName("Document Identification")]
public record DocumentIdentification9
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_RXptedp-Ed-ak6NoX_4Aeg_66239559")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }
}
