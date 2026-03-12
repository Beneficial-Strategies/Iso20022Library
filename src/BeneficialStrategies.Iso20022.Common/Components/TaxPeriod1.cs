// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Period of time details related to the tax payment.
/// </summary>
[IsoId("_UQSHctp-Ed-ak6NoX_4Aeg_2034124941")]
[DisplayName("Tax Period")]
public partial record TaxPeriod1
{
    #nullable enable
    
    /// <summary>
    /// Year related to the tax payment.
    /// </summary>
    [IsoId("_UQSHc9p-Ed-ak6NoX_4Aeg_-1889586026")]
    [DisplayName("Year")]
    [IsoXmlTag("Yr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Year { get; init; } 
    
    /// <summary>
    /// Identification of the period related to the tax payment.
    /// </summary>
    [IsoId("_UQSHdNp-Ed-ak6NoX_4Aeg_-1889586018")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TaxRecordPeriod1Code? Type { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for which the tax report is provided.
    /// </summary>
    [IsoId("_UQSHddp-Ed-ak6NoX_4Aeg_-1889585995")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DatePeriodDetails? FromToDate { get; init; } 
    
    
    #nullable disable
    
}
