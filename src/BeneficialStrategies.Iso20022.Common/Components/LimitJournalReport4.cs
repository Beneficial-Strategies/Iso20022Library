// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Journal Report4.
/// </summary>
[IsoId("_tmqQAZEhEe-Goq1fIU72qA")]
[DisplayName("Limit Journal Report4")]
public partial record LimitJournalReport4
{
    #nullable enable

    /// <summary>
    /// Limit Identification.
    /// </summary>
    [DisplayName("Limit Identification")]
    [IsoXmlTag("LmtId")]
    public required LimitIdentification7 LimitIdentification { get; init; } 

    /// <summary>
    /// Limit Report.
    /// </summary>
    [DisplayName("Limit Report")]
    [IsoXmlTag("LmtRpt")]
    public required LimitJournalReportOrError8Choice_ LimitReport { get; init; } 

    
    #nullable disable
    
}
