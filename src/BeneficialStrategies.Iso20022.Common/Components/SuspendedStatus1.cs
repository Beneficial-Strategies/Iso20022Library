// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is suspended.
/// </summary>
[IsoId("_UzSt59p-Ed-ak6NoX_4Aeg_-1626734948")]
[DisplayName("Suspended Status")]
public record SuspendedStatus1
{
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_UzSt6Np-Ed-ak6NoX_4Aeg_-1626734946")]
    [DisplayName("No Reason")]
    [IsoXmlTag("NoRsn")]
    public required NoReasonCode NoReason { get; init; }

    /// <summary>
    /// Reason for a suspended status in the report.
    /// </summary>
    [IsoId("_Uzce4Np-Ed-ak6NoX_4Aeg_-1110487797")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required SuspendedStatusReason1 Reason { get; init; }

    /// <summary>
    /// Proprietary identification of a reason for a suspended status in the report.
    /// </summary>
    [IsoId("_Uzce4dp-Ed-ak6NoX_4Aeg_-1626734687")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }
}
