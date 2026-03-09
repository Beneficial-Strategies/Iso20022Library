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
/// TimeFrame elements that define a period as number of days before or after a activity.
/// </summary>
[IsoId("_UAoh4Np-Ed-ak6NoX_4Aeg_-1899090252")]
[DisplayName("Time Frame")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TimeFrame3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies a description of any other TimeFrame that may be used for the DealingCutOffTimeFrame.
    /// </summary>
    [IsoId("_UAoh4dp-Ed-ak6NoX_4Aeg_-1857530882")]
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
    /// An agreed number of days before the Trade date (T) used to define standard timeframes e.g. T-1 Dealing cut off or T-2 prepayment condition||Where = T is the date that the price is applied to a transaction.
    /// </summary>
    [IsoId("_UAoh4tp-Ed-ak6NoX_4Aeg_-1899090190")]
    [DisplayName("Trade Minus")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TMns")]
    #endif
    [IsoXmlTag("TMns")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TradeMinus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TradeMinus { get; init; } 
    #else
    public System.UInt64? TradeMinus { get; set; } 
    #endif
    
    /// <summary>
    /// Convention used for adjusting a date when it is not a business day.
    /// </summary>
    [IsoId("_UAoh49p-Ed-ak6NoX_4Aeg_1418685838")]
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
    /// Refer to Order Desk.
    /// </summary>
    [IsoId("_UAoh5Np-Ed-ak6NoX_4Aeg_-242360634")]
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
