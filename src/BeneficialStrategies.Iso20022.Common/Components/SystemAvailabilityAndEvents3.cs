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
/// Specifies the details about the system availability and the related system events that might impact the availability.
/// </summary>
[IsoId("_dk-8wXhkEeidzqjNEfehPg")]
[DisplayName("System Availability And Events")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SystemAvailabilityAndEvents3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_dw2Og3hkEeidzqjNEfehPg")]
    [DisplayName("System Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysCcy")]
    #endif
    [IsoXmlTag("SysCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? SystemCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? SystemCurrency { get; init; } 
    #else
    public string? SystemCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Time window of system activity.
    /// </summary>
    [IsoId("_dw2OhXhkEeidzqjNEfehPg")]
    [DisplayName("Session Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SsnPrd")]
    #endif
    [IsoXmlTag("SsnPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimePeriod1? SessionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimePeriod1? SessionPeriod { get; init; } 
    #else
    public TimePeriod1? SessionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about an event occurring on a system, whether planned, such as the cut-off time for a specific type of eligible transfer, or unplanned (an unsolicited failure), as stipulated in the specifications of the system.
    /// </summary>
    [IsoId("_dw2Oh3hkEeidzqjNEfehPg")]
    [DisplayName("Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Evt")]
    #endif
    [IsoXmlTag("Evt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemEvent3? Event { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemEvent3? Event { get; init; } 
    #else
    public SystemEvent3? Event { get; set; } 
    #endif
    
    /// <summary>
    /// Information regarding the closure time of a system.
    /// </summary>
    [IsoId("_dw2OiXhkEeidzqjNEfehPg")]
    [DisplayName("Closure Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsrInf")]
    #endif
    [IsoXmlTag("ClsrInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemClosure2? ClosureInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemClosure2? ClosureInformation { get; init; } 
    #else
    public SystemClosure2? ClosureInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
