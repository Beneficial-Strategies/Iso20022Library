// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is suspended.
/// </summary>
[IsoId("_RGqrINp-Ed-ak6NoX_4Aeg_1793071793")]
[DisplayName("Suspended Status")]
public partial record SuspendedStatus2
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RGqrIdp-Ed-ak6NoX_4Aeg_1793071810")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    /// <summary>
    /// Reason for the suspended status.
    /// </summary>
    [IsoId("_RGqrItp-Ed-ak6NoX_4Aeg_-550374008")]
    [DisplayName("Reason Details")]
    [IsoXmlTag("RsnDtls")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<SuspendedStatusReason2> ReasonDetails { get; init; } = [];
    
    
    #nullable disable
    
}
