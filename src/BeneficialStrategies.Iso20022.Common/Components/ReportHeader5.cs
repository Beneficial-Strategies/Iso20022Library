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
[IsoId("_Dr8EK249EeiU9cctagi5ow")]
[DisplayName("Report Header")]
public record ReportHeader5
{
    /// <summary>
    /// Point to point reference as assigned by the case assigner to unambiguously identify the case status report.
    /// </summary>
    [IsoId("_D1oLo249EeiU9cctagi5ow")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party reporting the status of the investigation case.
    /// </summary>
    [IsoId("_D1oLpW49EeiU9cctagi5ow")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    public required Party40Choice_ From { get; init; }

    /// <summary>
    /// Party to which the status of the case is reported.
    /// </summary>
    [IsoId("_D1oLp249EeiU9cctagi5ow")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    public required Party40Choice_ To { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_D1oLqW49EeiU9cctagi5ow")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }
}
