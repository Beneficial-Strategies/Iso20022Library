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
/// Defines the criteria used to report on business day information.
/// </summary>
[IsoId("_75XVlqMgEeCJ6YNENx4h-w_-59874421")]
[DisplayName("Business Day Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BusinessDayReturnCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the system date is requested.
    /// </summary>
    [IsoId("_75XVl6MgEeCJ6YNENx4h-w_-1794151342")]
    [DisplayName("System Date Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysDtInd")]
    #endif
    [IsoXmlTag("SysDtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SystemDateIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemDateIndicator { get; init; } 
    #else
    public System.String? SystemDateIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the system status is requested.
    /// </summary>
    [IsoId("_75XVmKMgEeCJ6YNENx4h-w_-173713487")]
    [DisplayName("System Status Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysStsInd")]
    #endif
    [IsoXmlTag("SysStsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SystemStatusIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemStatusIndicator { get; init; } 
    #else
    public System.String? SystemStatusIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the system currency is requested.
    /// </summary>
    [IsoId("_75XVmaMgEeCJ6YNENx4h-w_-734965435")]
    [DisplayName("System Currency Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SysCcyInd")]
    #endif
    [IsoXmlTag("SysCcyInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SystemCurrencyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SystemCurrencyIndicator { get; init; } 
    #else
    public System.String? SystemCurrencyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the closure information is requested.
    /// </summary>
    [IsoId("_75gfgKMgEeCJ6YNENx4h-w_1130036750")]
    [DisplayName("Closure Period Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsrPrdInd")]
    #endif
    [IsoXmlTag("ClsrPrdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? ClosurePeriodIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosurePeriodIndicator { get; init; } 
    #else
    public System.String? ClosurePeriodIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the events are requested.
    /// </summary>
    [IsoId("_75gfgaMgEeCJ6YNENx4h-w_-1170785840")]
    [DisplayName("Event Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtInd")]
    #endif
    [IsoXmlTag("EvtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EventIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventIndicator { get; init; } 
    #else
    public System.String? EventIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the session period is requested.
    /// </summary>
    [IsoId("_75gfgqMgEeCJ6YNENx4h-w_2127109103")]
    [DisplayName("Session Period Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SsnPrdInd")]
    #endif
    [IsoXmlTag("SsnPrdInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? SessionPeriodIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SessionPeriodIndicator { get; init; } 
    #else
    public System.String? SessionPeriodIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the system event type is requested.
    /// </summary>
    [IsoId("_75gfg6MgEeCJ6YNENx4h-w_-1854786731")]
    [DisplayName("Event Type Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTpInd")]
    #endif
    [IsoXmlTag("EvtTpInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? EventTypeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EventTypeIndicator { get; init; } 
    #else
    public System.String? EventTypeIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
