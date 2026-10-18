// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDatePeriod3"/>
[IsoId("_Lk9JgUavEemG5fbqCekzMw")]
[DisplayName("Date Period")]
public partial record DatePeriod3
{
    /// <inheritdoc cref="IDatePeriod3.FromDate"/>
    [IsoId("_Lx7OgUavEemG5fbqCekzMw")]
    [DisplayName("From Date")]
    [IsoXmlTag("FrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate FromDate { get; init; }

    /// <inheritdoc cref="IDatePeriod3.ToDate"/>
    [IsoId("_Lx7Og0avEemG5fbqCekzMw")]
    [DisplayName("To Date")]
    [IsoXmlTag("ToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ToDate { get; init; }
}
