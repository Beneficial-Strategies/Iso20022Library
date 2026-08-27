// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation of data related report.
/// </summary>
[IsoId("_DE9U0GF8EfC07JR6e2JJ-w")]
[DisplayName("Cancel Report1")]
public record CancelReport1
{
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_Nt7eoGF8EfC07JR6e2JJ-w")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required IsoMax140Text ReportIdentification { get; init; }
}
