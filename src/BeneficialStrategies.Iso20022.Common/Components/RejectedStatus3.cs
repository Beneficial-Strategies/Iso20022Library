// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is rejected.
/// </summary>
[IsoId("_U23mVNp-Ed-ak6NoX_4Aeg_-2053158623")]
[DisplayName("Rejected Status")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2016-09-08.")]
public record RejectedStatus3
{
    /// <summary>
    /// Reason for a rejected status in the report.
    /// </summary>
    [IsoId("_U23mVdp-Ed-ak6NoX_4Aeg_96799303")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<RejectedStatusReason6> Reason { get; init; } = [];

    /// <summary>
    /// Proprietary identification of a reason for a rejected status in the report.
    /// </summary>
    [IsoId("_U23mVtp-Ed-ak6NoX_4Aeg_-2053158562")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<GenericIdentification1> DataSourceScheme { get; init; } = [];
}
