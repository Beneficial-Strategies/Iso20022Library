// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of report.
/// </summary>
[IsoId("_RJ8opdp-Ed-ak6NoX_4Aeg_1748144086")]
[DisplayName("Report Type")]
public partial record ReportType1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the pushed through baseline is a new one or an amendment or a resubmission.
    /// </summary>
    [IsoId("_RJ8optp-Ed-ak6NoX_4Aeg_2004884777")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ReportType1Code Type { get; init; } 
    
    
    #nullable disable
    
}
