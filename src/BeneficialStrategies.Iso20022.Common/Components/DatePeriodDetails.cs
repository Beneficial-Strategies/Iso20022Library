// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDatePeriodDetails"/>
[IsoId("_T-soNtp-Ed-ak6NoX_4Aeg_330596074")]
[DisplayName("Date Period Details")]
public partial record DatePeriodDetails
{
    /// <inheritdoc cref="IDatePeriodDetails.FromDate"/>
    [IsoId("_T-soN9p-Ed-ak6NoX_4Aeg_330596075")]
    [DisplayName("From Date")]
    [IsoXmlTag("FrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate FromDate { get; init; }

    /// <inheritdoc cref="IDatePeriodDetails.ToDate"/>
    [IsoId("_T-soONp-Ed-ak6NoX_4Aeg_330596076")]
    [DisplayName("To Date")]
    [IsoXmlTag("ToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ToDate { get; init; }
}
