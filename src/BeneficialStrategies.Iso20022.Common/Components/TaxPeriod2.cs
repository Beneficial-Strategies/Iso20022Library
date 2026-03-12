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
[IsoId("_zCdv5a9fEeen6L7OP7lnvg")]
[DisplayName("Tax Period")]
public partial record TaxPeriod2
{
    #nullable enable
    
    /// <summary>
    /// Year related to the tax payment.
    /// </summary>
    [IsoId("_zSrWIa9fEeen6L7OP7lnvg")]
    [DisplayName("Year")]
    [IsoXmlTag("Yr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Year { get; init; } 
    
    /// <summary>
    /// Identification of the period related to the tax payment.
    /// </summary>
    [IsoId("_zSrWI69fEeen6L7OP7lnvg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TaxRecordPeriod1Code? Type { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for which the tax report is provided.
    /// </summary>
    [IsoId("_zSrWJa9fEeen6L7OP7lnvg")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DatePeriod2? FromToDate { get; init; } 
    
    
    #nullable disable
    
}
