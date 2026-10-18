// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxPeriod2"/>
[IsoId("_zCdv5a9fEeen6L7OP7lnvg")]
[DisplayName("Tax Period")]
public partial record TaxPeriod2
{
    /// <inheritdoc cref="ITaxPeriod2.Year"/>
    [IsoId("_zSrWIa9fEeen6L7OP7lnvg")]
    [DisplayName("Year")]
    [IsoXmlTag("Yr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Year { get; init; }

    /// <inheritdoc cref="ITaxPeriod2.Type"/>
    [IsoId("_zSrWI69fEeen6L7OP7lnvg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TaxRecordPeriod1Code? Type { get; init; }

    /// <inheritdoc cref="ITaxPeriod2.FromToDate"/>
    [IsoId("_zSrWJa9fEeen6L7OP7lnvg")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DatePeriod2? FromToDate { get; init; }
}
