// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ITaxPeriod1"/>
[IsoId("_UQSHctp-Ed-ak6NoX_4Aeg_2034124941")]
[DisplayName("Tax Period")]
public partial record TaxPeriod1
{
    /// <inheritdoc cref="ITaxPeriod1.Year"/>
    [IsoId("_UQSHc9p-Ed-ak6NoX_4Aeg_-1889586026")]
    [DisplayName("Year")]
    [IsoXmlTag("Yr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Year { get; init; }

    /// <inheritdoc cref="ITaxPeriod1.Type"/>
    [IsoId("_UQSHdNp-Ed-ak6NoX_4Aeg_-1889586018")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TaxRecordPeriod1Code? Type { get; init; }

    /// <inheritdoc cref="ITaxPeriod1.FromToDate"/>
    [IsoId("_UQSHddp-Ed-ak6NoX_4Aeg_-1889585995")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DatePeriodDetails? FromToDate { get; init; }
}
