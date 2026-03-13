// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status is accepted under certain conditions.
/// </summary>
[IsoId("_RM7EKdp-Ed-ak6NoX_4Aeg_-367108012")]
[DisplayName("Conditionally Accepted Status")]
public partial record ConditionallyAcceptedStatus2
{
    #nullable enable
    
    /// <summary>
    /// Indicates that there is no reason available or to report.
    /// </summary>
    [IsoId("_RM7EKtp-Ed-ak6NoX_4Aeg_-367107934")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    /// <summary>
    /// Reason for the conditionally accepted status.
    /// </summary>
    [IsoId("_RM7EK9p-Ed-ak6NoX_4Aeg_1592724754")]
    [DisplayName("Reason Details")]
    [IsoXmlTag("RsnDtls")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<ConditionallyAcceptedStatusReason2> ReasonDetails { get; init; } = [];
    
    
    #nullable disable
    
}
