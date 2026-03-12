// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment system operational information, such as opening, closure, session period or events, given per currency.
/// </summary>
[IsoId("_OYVo5XXyEei3jO6riKEVXg")]
[DisplayName("Business Day")]
public partial record BusinessDay9
{
    #nullable enable
    
    /// <summary>
    /// Date for which the availability information is provided.
    /// </summary>
    [IsoId("_OinmQXXyEei3jO6riKEVXg")]
    [DisplayName("System Date")]
    [IsoXmlTag("SysDt")]
    public DateAndDateTime2Choice_? SystemDate { get; init; } 
    
    /// <summary>
    /// Status of a system and the period of time during which the status is valid.
    /// </summary>
    [IsoId("_OinmQ3XyEei3jO6riKEVXg")]
    [DisplayName("System Status")]
    [IsoXmlTag("SysSts")]
    public SystemStatus3? SystemStatus { get; init; } 
    
    /// <summary>
    /// Information relating to system operations and foreseen events relating to the operation of the system.
    /// </summary>
    [IsoId("_OinmRXXyEei3jO6riKEVXg")]
    [DisplayName("System Information Per Currency")]
    [IsoXmlTag("SysInfPerCcy")]
    public SystemAvailabilityAndEvents3? SystemInformationPerCurrency { get; init; } 
    
    
    #nullable disable
    
}
