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
/// Processing characteristics linked to the instrument, ie, not to the market.
/// </summary>
[IsoId("_UBrDs9p-Ed-ak6NoX_4Aeg_651074944")]
[DisplayName("Processing Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingCharacteristics1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProcessingCharacteristics1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProcessingCharacteristics1( System.String reqAmountIndicator,System.String reqUnitsIndicator,System.TimeOnly reqDealingCutOffTime,TimeFrame3Choice_ reqDealingCutOffTimeFrame,Timeframe2Choice_ reqSettlementCycle )
    {
        AmountIndicator = reqAmountIndicator;
        UnitsIndicator = reqUnitsIndicator;
        DealingCutOffTime = reqDealingCutOffTime;
        DealingCutOffTimeFrame = reqDealingCutOffTimeFrame;
        SettlementCycle = reqSettlementCycle;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether a subscription or a redemption can be instructed by amount.
    /// </summary>
    [IsoId("_UBrDtNp-Ed-ak6NoX_4Aeg_1742686060")]
    [DisplayName("Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtInd")]
    #endif
    [IsoXmlTag("AmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AmountIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AmountIndicator { get; init; } 
    #else
    public System.String AmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether subscriptions or redemptions may be placed as a number of units.
    /// </summary>
    [IsoId("_UBrDtdp-Ed-ak6NoX_4Aeg_1448711749")]
    [DisplayName("Units Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsInd")]
    #endif
    [IsoXmlTag("UnitsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator UnitsIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String UnitsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String UnitsIndicator { get; init; } 
    #else
    public System.String UnitsIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a subscription or redemption is accepted.
    /// </summary>
    [IsoId("_UBrDttp-Ed-ak6NoX_4Aeg_1655381109")]
    [DisplayName("Dealing Currency Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgCcyAccptd")]
    #endif
    [IsoXmlTag("DealgCcyAccptd")]
    public SimpleValueList<string> DealingCurrencyAccepted { get; init; } = new SimpleValueList<string>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _UBrDttp-Ed-ak6NoX_4Aeg_1655381109
    
    /// <summary>
    /// Last date/time at which an order to subscribe or redeem can be given.
    /// </summary>
    [IsoId("_UBrDt9p-Ed-ak6NoX_4Aeg_1609988215")]
    [DisplayName("Dealing Cut Off Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgCutOffTm")]
    #endif
    [IsoXmlTag("DealgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISOTime DealingCutOffTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.TimeOnly DealingCutOffTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly DealingCutOffTime { get; init; } 
    #else
    public System.TimeOnly DealingCutOffTime { get; set; } 
    #endif
    
    /// <summary>
    /// TimeFrame or period concept that allows definition of a period as number of days before or after a defined activity.
    /// </summary>
    [IsoId("_UBrDuNp-Ed-ak6NoX_4Aeg_-189448505")]
    [DisplayName("Dealing Cut Off Time Frame")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgCutOffTmFrame")]
    #endif
    [IsoXmlTag("DealgCutOffTmFrame")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TimeFrame3Choice_ DealingCutOffTimeFrame { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TimeFrame3Choice_ DealingCutOffTimeFrame { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame3Choice_ DealingCutOffTimeFrame { get; init; } 
    #else
    public TimeFrame3Choice_ DealingCutOffTimeFrame { get; set; } 
    #endif
    
    /// <summary>
    /// An agreed number of days after the Trade date (T) used to define standard timeframes e.g T+3 settlement period ||Where T = the date the price is applied to a transaction.
    /// </summary>
    [IsoId("_UB00sNp-Ed-ak6NoX_4Aeg_-1103139328")]
    [DisplayName("Settlement Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCycl")]
    #endif
    [IsoXmlTag("SttlmCycl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Timeframe2Choice_ SettlementCycle { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Timeframe2Choice_ SettlementCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Timeframe2Choice_ SettlementCycle { get; init; } 
    #else
    public Timeframe2Choice_ SettlementCycle { get; set; } 
    #endif
    
    
    #nullable disable
    
}
