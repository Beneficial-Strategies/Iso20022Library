// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxPeriod3"/>
[IsoId("_oB4Gpd4lEeqt1ZcLzWyWFw")]
[DisplayName("Tax Period")]
public partial record TaxPeriod3
{
    /// <inheritdoc cref="ITaxPeriod3.Year"/>
    [IsoId("_oDl94d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Year")]
    [IsoXmlTag("Yr")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    public IsoISOYear? Year { get; init; }

    /// <inheritdoc cref="ITaxPeriod3.Type"/>
    [IsoId("_oDl9494lEeqt1ZcLzWyWFw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TaxRecordPeriod1Code? Type { get; init; }

    /// <inheritdoc cref="ITaxPeriod3.FromToDate"/>
    [IsoId("_oDl95d4lEeqt1ZcLzWyWFw")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DatePeriod2? FromToDate { get; init; }
}
