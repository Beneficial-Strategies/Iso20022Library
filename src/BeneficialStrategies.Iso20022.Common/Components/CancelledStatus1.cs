// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is cancelled.
/// </summary>
[IsoId("_UwnNXNp-Ed-ak6NoX_4Aeg_-1540666967")]
[DisplayName("Cancelled Status")]
public partial record CancelledStatus1
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_Uww-UNp-Ed-ak6NoX_4Aeg_-1540666948")]
    [DisplayName("No Reason")]
    [IsoXmlTag("NoRsn")]
    public required NoReasonCode NoReason { get; init; } 
    
    /// <summary>
    /// Reason for a cancelled status in the report.
    /// </summary>
    [IsoId("_Uww-Udp-Ed-ak6NoX_4Aeg_-1540666611")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CancelledStatusReason1 Reason { get; init; } 
    
    /// <summary>
    /// Proprietary identification of a reason for a cancelled status in the report.
    /// </summary>
    [IsoId("_Uww-Utp-Ed-ak6NoX_4Aeg_-1540666906")]
    [DisplayName("Data Source Scheme")]
    [IsoXmlTag("DataSrcSchme")]
    public required GenericIdentification1 DataSourceScheme { get; init; } 
    
    
    #nullable disable
    
}
