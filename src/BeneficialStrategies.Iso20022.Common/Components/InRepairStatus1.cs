// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is in repair.
/// </summary>
[IsoId("_Uuhiptp-Ed-ak6NoX_4Aeg_-794783023")]
[DisplayName("In Repair Status")]
public record InRepairStatus1
{
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_UurToNp-Ed-ak6NoX_4Aeg_-794782787")]
    [DisplayName("No Reason")]
    [IsoXmlTag("NoRsn")]
    public required NoReasonCode NoReason { get; init; }

    /// <summary>
    /// Reason of an in repair status in the report.
    /// </summary>
    [IsoId("_UurTodp-Ed-ak6NoX_4Aeg_-794782710")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required InRepairStatusReason1 Reason { get; init; }

    /// <summary>
    /// Proprietary identification for a reason of a specific status in the report.
    /// </summary>
    [IsoId("_UurTotp-Ed-ak6NoX_4Aeg_-794782752")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }
}
