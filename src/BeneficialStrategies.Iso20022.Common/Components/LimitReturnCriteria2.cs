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
/// Defines the criteria used to report on limit.
/// </summary>
[IsoId("_76joYqMgEeCJ6YNENx4h-w_915944242")]
[DisplayName("Limit Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LimitReturnCriteria2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the limit start date time is requested.
    /// </summary>
    [IsoId("_76joY6MgEeCJ6YNENx4h-w_1532338031")]
    [DisplayName("Start Date Time Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDtTmInd")]
    #endif
    [IsoXmlTag("StartDtTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? StartDateTimeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StartDateTimeIndicator { get; init; } 
    #else
    public System.String? StartDateTimeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the limit status is requested.
    /// </summary>
    [IsoId("_76joZKMgEeCJ6YNENx4h-w_2002414441")]
    [DisplayName("Status Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInd")]
    #endif
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? StatusIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatusIndicator { get; init; } 
    #else
    public System.String? StatusIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the limit used amount is requested.
    /// </summary>
    [IsoId("_76joZaMgEeCJ6YNENx4h-w_-611823697")]
    [DisplayName("Used Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsdAmtInd")]
    #endif
    [IsoXmlTag("UsdAmtInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? UsedAmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UsedAmountIndicator { get; init; } 
    #else
    public System.String? UsedAmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the limit used percentage is requested.
    /// </summary>
    [IsoId("_76joZqMgEeCJ6YNENx4h-w_1711979106")]
    [DisplayName("Used Percentage Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UsdPctgInd")]
    #endif
    [IsoXmlTag("UsdPctgInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? UsedPercentageIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UsedPercentageIndicator { get; init; } 
    #else
    public System.String? UsedPercentageIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
