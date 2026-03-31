// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of time defined by a start date and an end date.
/// </summary>
[IsoId("_T-1yKNp-Ed-ak6NoX_4Aeg_-1267403940")]
[DisplayName("Date Period Details")]
public record DatePeriodDetails1
{
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_T-_jINp-Ed-ak6NoX_4Aeg_-1267403939")]
    [DisplayName("From Date")]
    [IsoXmlTag("FrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate FromDate { get; init; }

    /// <summary>
    /// End date of the range.
    /// </summary>
    [IsoId("_T-_jIdp-Ed-ak6NoX_4Aeg_-1267403938")]
    [DisplayName("To Date")]
    [IsoXmlTag("ToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ToDate { get; init; }
}
