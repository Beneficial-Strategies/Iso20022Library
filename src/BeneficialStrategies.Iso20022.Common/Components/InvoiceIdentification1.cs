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
[IsoId("_RaVOAtp-Ed-ak6NoX_4Aeg_905732542")]
[DisplayName("Invoice Identification")]
public record InvoiceIdentification1
{
    /// <summary>
    /// Identifies the document.
    /// </summary>
    [IsoId("_RaVOA9p-Ed-ak6NoX_4Aeg_905732551")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text InvoiceNumber { get; init; }

    /// <summary>
    /// Date of issuance of the document.
    /// </summary>
    [IsoId("_RaVOBNp-Ed-ak6NoX_4Aeg_905732603")]
    [DisplayName("Issue Date")]
    [IsoXmlTag("IsseDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate IssueDate { get; init; }
}
