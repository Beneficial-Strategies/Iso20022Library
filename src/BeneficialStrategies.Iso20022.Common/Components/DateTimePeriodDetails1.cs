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
[IsoId("_T5xr8dp-Ed-ak6NoX_4Aeg_-1128572161")]
[DisplayName("Date Time Period Details")]
public record DateTimePeriodDetails1
{
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    [IsoId("_T5xr8tp-Ed-ak6NoX_4Aeg_-1154857257")]
    [DisplayName("From Date Time")]
    [IsoXmlTag("FrDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime FromDateTime { get; init; }

    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    [IsoId("_T5xr89p-Ed-ak6NoX_4Aeg_-1154856854")]
    [DisplayName("To Date Time")]
    [IsoXmlTag("ToDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ToDateTime { get; init; }
}
