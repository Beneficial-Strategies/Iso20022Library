// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the requested reporting period.
/// </summary>
[IsoId("_vN1qlRN5EeumtumXS98aGg")]
[DisplayName("Reporting Period")]
public partial record ReportingPeriod5
{
    #nullable enable
    
    /// <summary>
    /// Specifies a date range.
    /// </summary>
    [IsoId("_vO4zcRN5EeumtumXS98aGg")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public required DatePeriod3 FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies a time range.
    /// </summary>
    [IsoId("_vO4zcxN5EeumtumXS98aGg")]
    [DisplayName("From To Time")]
    [IsoXmlTag("FrToTm")]
    public TimePeriodDetails1? FromToTime { get; init; } 
    
    /// <summary>
    /// Specifies whether all matching items need to be reported or only those items that are new or have changed since the last similar request was made.
    /// </summary>
    [IsoId("_vO4zdRN5EeumtumXS98aGg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required QueryType3Code Type { get; init; } 
    
    
    #nullable disable
    
}
