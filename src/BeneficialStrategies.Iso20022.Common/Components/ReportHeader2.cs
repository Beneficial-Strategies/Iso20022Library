// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies generic information about an investigation report.
/// </summary>
[IsoId("_Rq4LdNp-Ed-ak6NoX_4Aeg_891312394")]
[DisplayName("Report Header")]
public record ReportHeader2
{
    /// <summary>
    /// Point to point reference as assigned by the case assigner to unambiguously identify the case status report.
    /// </summary>
    [IsoId("_Rq4Lddp-Ed-ak6NoX_4Aeg_891312426")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party reporting the status of the investigation case.
    /// </summary>
    [IsoId("_Rq4Ldtp-Ed-ak6NoX_4Aeg_551455927")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party7Choice_ From { get; init; }

    /// <summary>
    /// Party to which the status of the case is reported.
    /// </summary>
    [IsoId("_RrBVYNp-Ed-ak6NoX_4Aeg_551455874")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party7Choice_ To { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_RrBVYdp-Ed-ak6NoX_4Aeg_891312540")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }
}
