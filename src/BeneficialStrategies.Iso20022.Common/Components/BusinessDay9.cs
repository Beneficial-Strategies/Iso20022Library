// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment system operational information, such as opening, closure, session period or events, given per currency.
/// </summary>
[IsoId("_OYVo5XXyEei3jO6riKEVXg")]
[DisplayName("Business Day")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessDay9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date for which the availability information is provided.
    /// </summary>
    [IsoId("_OinmQXXyEei3jO6riKEVXg")]
    [DisplayName("System Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysDt")]
    #endif
    [IsoXmlTag("SysDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? SystemDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? SystemDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? SystemDate { get; set; } 
    #endif
    
    /// <summary>
    /// Status of a system and the period of time during which the status is valid.
    /// </summary>
    [IsoId("_OinmQ3XyEei3jO6riKEVXg")]
    [DisplayName("System Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysSts")]
    #endif
    [IsoXmlTag("SysSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemStatus3? SystemStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemStatus3? SystemStatus { get; init; } 
    #else
    public SystemStatus3? SystemStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Information relating to system operations and foreseen events relating to the operation of the system.
    /// </summary>
    [IsoId("_OinmRXXyEei3jO6riKEVXg")]
    [DisplayName("System Information Per Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysInfPerCcy")]
    #endif
    [IsoXmlTag("SysInfPerCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemAvailabilityAndEvents3? SystemInformationPerCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemAvailabilityAndEvents3? SystemInformationPerCurrency { get; init; } 
    #else
    public SystemAvailabilityAndEvents3? SystemInformationPerCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
