// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a document by a unique identification and a date of issue.
/// </summary>
[IsoId("_WwHXgdOWEeSQ_-lmj1tzfw")]
[DisplayName("Document Identification")]
public record DocumentIdentification28
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_W6O80dOWEeSQ_-lmj1tzfw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Identification { get; init; }

    /// <summary>
    /// Date of issuance of the document.
    /// </summary>
    [IsoId("_W6O809OWEeSQ_-lmj1tzfw")]
    [DisplayName("Date Of Issue")]
    [IsoXmlTag("DtOfIsse")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateOfIssue { get; init; }
}
