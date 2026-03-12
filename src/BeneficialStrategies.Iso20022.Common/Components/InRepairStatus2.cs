// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is in repair.
/// </summary>
[IsoId("_RMeYNtp-Ed-ak6NoX_4Aeg_-329740653")]
[DisplayName("In Repair Status")]
public partial record InRepairStatus2
{
    #nullable enable
    
    /// <summary>
    /// Reason for the in-repair status.
    /// </summary>
    [IsoId("_RMeYN9p-Ed-ak6NoX_4Aeg_-2034253428")]
    [DisplayName("Reason Details")]
    [IsoXmlTag("RsnDtls")]
    public required InRepairStatusReason3 ReasonDetails { get; init; } 
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RMeYONp-Ed-ak6NoX_4Aeg_-329740627")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    
    #nullable disable
    
}
