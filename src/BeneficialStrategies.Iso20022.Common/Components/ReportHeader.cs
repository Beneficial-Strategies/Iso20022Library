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
[IsoId("_RI5fwNp-Ed-ak6NoX_4Aeg_24374172")]
[DisplayName("Report Header")]
public record ReportHeader
{
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_RI5fwdp-Ed-ak6NoX_4Aeg_-1998731747")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; }

    /// <summary>
    /// Party reporting the status of the case.
    /// </summary>
    [IsoId("_RI5fwtp-Ed-ak6NoX_4Aeg_-1991343595")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier From { get; init; }

    /// <summary>
    /// Party to which the status of the case is reported.
    /// </summary>
    [IsoId("_RI5fw9p-Ed-ak6NoX_4Aeg_-1981183608")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier To { get; init; }

    /// <summary>
    /// Creation date and time of the report generation.
    /// </summary>
    [IsoId("_RI5fxNp-Ed-ak6NoX_4Aeg_-1970102765")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }
}
