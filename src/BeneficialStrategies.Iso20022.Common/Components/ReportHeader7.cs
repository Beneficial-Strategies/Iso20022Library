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
[IsoId("_1LHsITEyEe6g-ffJsqGiSA")]
[DisplayName("Report Header7")]
public record ReportHeader7
{
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Party reporting the status of the investigation case.
    /// </summary>
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party50Choice_ From { get; init; }

    /// <summary>
    /// Point to point reference as assigned by the case assigner to unambiguously identify the case status report.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party to which the status of the case is reported.
    /// </summary>
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party50Choice_ To { get; init; }
}
