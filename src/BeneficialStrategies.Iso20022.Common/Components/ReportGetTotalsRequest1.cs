// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Get Totals Request message.
/// </summary>
[IsoId("_mY7jcN6SEeiwsev40qZGEQ")]
[DisplayName("Report Get Totals Request")]
public record ReportGetTotalsRequest1
{
    /// <summary>
    /// Indicates the hierarchical structure of the report.
    /// </summary>
    [IsoId("_s0kxMN6SEeiwsev40qZGEQ")]
    [DisplayName("Total Details")]
    [IsoXmlTag("TtlDtls")]
    public TotalDetails1Code? TotalDetails { get; init; }

    /// <summary>
    /// Filter to compute the totals.
    /// </summary>
    [IsoId("_Pc6eMN6TEeiwsev40qZGEQ")]
    [DisplayName("Total Filter")]
    [IsoXmlTag("TtlFltr")]
    public TotalFilter1? TotalFilter { get; init; }
}
