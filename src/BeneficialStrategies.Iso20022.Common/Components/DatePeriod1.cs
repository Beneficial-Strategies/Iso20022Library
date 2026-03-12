// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of time defined by a start date and an end date.
/// </summary>
[IsoId("_6T03GpqlEeGSON8vddiWzQ_1589848859")]
[DisplayName("Date Period")]
public partial record DatePeriod1
{
    #nullable enable
    
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_6T03G5qlEeGSON8vddiWzQ_2053251952")]
    [DisplayName("From Date")]
    [IsoXmlTag("FrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FromDate { get; init; } 
    
    /// <summary>
    /// End date of the range.
    /// </summary>
    [IsoId("_6T03HJqlEeGSON8vddiWzQ_-1787628075")]
    [DisplayName("To Date")]
    [IsoXmlTag("ToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ToDate { get; init; } 
    
    
    #nullable disable
    
}
