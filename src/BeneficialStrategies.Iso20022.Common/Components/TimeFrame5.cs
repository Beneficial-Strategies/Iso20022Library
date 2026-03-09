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
/// Time frame elements that define a period as number of days before or after a activity.
/// </summary>
[IsoId("_eJEWwV81Eeicg40_9gK9vQ")]
[DisplayName("Time Frame")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TimeFrame5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Description of the timeframe.
    /// </summary>
    [IsoId("_eY14JV81Eeicg40_9gK9vQ")]
    [DisplayName("Other Time Frame Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTmFrameDesc")]
    #endif
    [IsoXmlTag("OthrTmFrameDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? OtherTimeFrameDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherTimeFrameDescription { get; init; } 
    #else
    public System.String? OtherTimeFrameDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days after the trade date (T) used for the standard timeframe for the issue of a deal confirmation.
    /// </summary>
    [IsoId("_eY14J181Eeicg40_9gK9vQ")]
    [DisplayName("Trade Plus")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TPlus")]
    #endif
    [IsoXmlTag("TPlus")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TradePlus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TradePlus { get; init; } 
    #else
    public System.UInt64? TradePlus { get; set; } 
    #endif
    
    /// <summary>
    /// Convention used for adjusting a date when it is not a business day.
    /// </summary>
    [IsoId("_eY14KV81Eeicg40_9gK9vQ")]
    [DisplayName("Non Working Day Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonWorkgDayAdjstmnt")]
    #endif
    [IsoXmlTag("NonWorkgDayAdjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; init; } 
    #else
    public BusinessDayConvention1Code? NonWorkingDayAdjustment { get; set; } 
    #endif
    
    /// <summary>
    /// For the time of the issuance of the deal confirmation, the order desk must be contacted.
    /// </summary>
    [IsoId("_eY14K181Eeicg40_9gK9vQ")]
    [DisplayName("Refer To Order Desk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RefrToOrdrDsk")]
    #endif
    [IsoXmlTag("RefrToOrdrDsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; init; } 
    #else
    public ReferToFundOrderDesk1Code? ReferToOrderDesk { get; set; } 
    #endif
    
    
    #nullable disable
    
}
