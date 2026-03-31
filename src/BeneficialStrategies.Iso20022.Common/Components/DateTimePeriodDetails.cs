// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
[IsoId("_T5xr9Np-Ed-ak6NoX_4Aeg_330596091")]
[DisplayName("Date Time Period Details")]
public record DateTimePeriodDetails
{
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_T5xr9dp-Ed-ak6NoX_4Aeg_330596092")]
    [DisplayName("From Date Time")]
    [IsoXmlTag("FrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime FromDateTime { get; init; }

    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_T5xr9tp-Ed-ak6NoX_4Aeg_330596093")]
    [DisplayName("To Date Time")]
    [IsoXmlTag("ToDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime ToDateTime { get; init; }
}
