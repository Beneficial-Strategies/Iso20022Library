// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status that is accepted under certain conditions.
/// </summary>
[IsoId("_UyQMGtp-Ed-ak6NoX_4Aeg_94624297")]
[DisplayName("Conditionally Accepted Status")]
public record ConditionallyAcceptedStatus1
{
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_UyZ9ENp-Ed-ak6NoX_4Aeg_94624315")]
    [DisplayName("No Reason")]
    [IsoXmlTag("NoRsn")]
    public required NoReasonCode NoReason { get; init; }

    /// <summary>
    /// Reason for a conditionally accepted status in the report.
    /// </summary>
    [IsoId("_UyZ9Edp-Ed-ak6NoX_4Aeg_95544442")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required ConditionallyAcceptedStatusReason1 Reason { get; init; }

    /// <summary>
    /// Proprietary identification of a reason for a conditionally accepted status in the report.
    /// </summary>
    [IsoId("_UyZ9Etp-Ed-ak6NoX_4Aeg_95544382")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; }
}
