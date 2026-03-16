// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Limit Journal Report4.
/// </summary>
[IsoId("_tmqQAZEhEe-Goq1fIU72qA")]
[DisplayName("Limit Journal Report4")]
public record LimitJournalReport4
{
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
}
