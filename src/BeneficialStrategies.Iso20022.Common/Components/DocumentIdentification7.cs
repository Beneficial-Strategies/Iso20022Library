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
[IsoId("_RJf8sNp-Ed-ak6NoX_4Aeg_295308552")]
[DisplayName("Document Identification")]
public record DocumentIdentification7
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_RJf8sdp-Ed-ak6NoX_4Aeg_598222416")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Date of issuance of the document.
    /// </summary>
    [IsoId("_RJf8stp-Ed-ak6NoX_4Aeg_610229645")]
    [DisplayName("Date Of Issue")]
    [IsoXmlTag("DtOfIsse")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate DateOfIssue { get; init; }
}
