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
[IsoId("_FEM-0Yy1EeeGkvZr3jtnCQ")]
[DisplayName("Reporting Period")]
public partial record ReportingPeriod2
{
    #nullable enable
    
    /// <summary>
    /// Specifies a date range.
    /// </summary>
    [IsoId("_FNSCUYy1EeeGkvZr3jtnCQ")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public required DatePeriodDetails1 FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies a time range.
    /// </summary>
    [IsoId("_FNSCU4y1EeeGkvZr3jtnCQ")]
    [DisplayName("From To Time")]
    [IsoXmlTag("FrToTm")]
    public TimePeriodDetails1? FromToTime { get; init; } 
    
    /// <summary>
    /// Specifies whether all matching items need to be reported or only those items that are new or have changed since the last similar request was made.
    /// </summary>
    [IsoId("_FNSCVYy1EeeGkvZr3jtnCQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required QueryType3Code Type { get; init; } 
    
    
    #nullable disable
    
}
