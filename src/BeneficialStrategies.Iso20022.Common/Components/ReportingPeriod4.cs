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
[IsoId("_yAlL4e5pEemXBpiFxCCWFQ")]
[DisplayName("Reporting Period")]
public partial record ReportingPeriod4
{
    #nullable enable
    
    /// <summary>
    /// Specifies a date range.
    /// </summary>
    [IsoId("_yNg0oe5pEemXBpiFxCCWFQ")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public required DatePeriod3 FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies a time range.
    /// </summary>
    [IsoId("_yNg0o-5pEemXBpiFxCCWFQ")]
    [DisplayName("From To Time")]
    [IsoXmlTag("FrToTm")]
    public required TimePeriod2 FromToTime { get; init; } 
    
    /// <summary>
    /// Specifies whether all matching items need to be reported or only those items that are new or have changed since the last similar request was made.
    /// </summary>
    [IsoId("_yNg0pe5pEemXBpiFxCCWFQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required QueryType3Code Type { get; init; } 
    
    
    #nullable disable
    
}
