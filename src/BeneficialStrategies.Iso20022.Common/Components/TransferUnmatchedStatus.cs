// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is unmatched.
/// </summary>
[IsoId("_U0V2xNp-Ed-ak6NoX_4Aeg_-105274052")]
[DisplayName("Transfer Unmatched Status")]
public partial record TransferUnmatchedStatus
{
    #nullable enable
    
    /// <summary>
    /// Reason for an unmatched status in the report.
    /// </summary>
    [IsoId("_U0V2xdp-Ed-ak6NoX_4Aeg_759138876")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required TransferUnmatchedStatusReason1 Reason { get; init; } 
    
    /// <summary>
    /// Proprietary identification for a reason of a specific status in the report.
    /// </summary>
    [IsoId("_U0V2xtp-Ed-ak6NoX_4Aeg_94206093")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_U0V2x9p-Ed-ak6NoX_4Aeg_72964022")]
    [DisplayName("No Reason")]
    [IsoXmlTag("NoRsn")]
    public required NoReasonCode NoReason { get; init; } 
    
    
    #nullable disable
    
}
