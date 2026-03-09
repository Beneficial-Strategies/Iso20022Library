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
[IsoId("_UBFN1Np-Ed-ak6NoX_4Aeg_1281373754")]
[DisplayName("Processing Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingCharacteristics2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ProcessingCharacteristics2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ProcessingCharacteristics2( Forms reqInitialInvestment,Forms reqSubsequentInvestment,System.String reqAmountIndicator,System.String reqUnitsIndicator,MainFundOrderDeskLocation1 reqMainFundOrderDeskLocation,System.TimeOnly reqDealingCutOffTime,TimeFrame3 reqDealingCutOffTimeFrame,EventFrequency5Code reqDealingFrequency,System.String reqDealingFrequencyDescription,TimeFrame5Choice_ reqSettlementCycle )
    {
        InitialInvestment = reqInitialInvestment;
        SubsequentInvestment = reqSubsequentInvestment;
        AmountIndicator = reqAmountIndicator;
        UnitsIndicator = reqUnitsIndicator;
        MainFundOrderDeskLocation = reqMainFundOrderDeskLocation;
        DealingCutOffTime = reqDealingCutOffTime;
        DealingCutOffTimeFrame = reqDealingCutOffTimeFrame;
        DealingFrequency = reqDealingFrequency;
        DealingFrequencyDescription = reqDealingFrequencyDescription;
        SettlementCycle = reqSettlementCycle;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency in which a subscription or redemption is accepted.
    /// </summary>
    [IsoId("_UBFN1dp-Ed-ak6NoX_4Aeg_462420073")]
    [DisplayName("Dealing Currency Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgCcyAccptd")]
    #endif
    [IsoXmlTag("DealgCcyAccptd")]
    public SimpleValueList<string> DealingCurrencyAccepted { get; init; } = new SimpleValueList<string>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _UBFN1dp-Ed-ak6NoX_4Aeg_462420073
    
    /// <summary>
    /// Minimum initial quantity of securities, expressed as an amount that must be purchased at subscription.
    /// </summary>
    [IsoId("_UBFN1tp-Ed-ak6NoX_4Aeg_-1044327809")]
    [DisplayName("Initial Investment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlInvstmt")]
    #endif
    [IsoXmlTag("InitlInvstmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Forms InitialInvestment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Forms InitialInvestment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Forms InitialInvestment { get; init; } 
    #else
    public Forms InitialInvestment { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of securities, expressed as number of units/shares that must be purchased.
    /// </summary>
    [IsoId("_UBFN19p-Ed-ak6NoX_4Aeg_-1790398090")]
    [DisplayName("Subsequent Investment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbsqntInvstmt")]
    #endif
    [IsoXmlTag("SbsqntInvstmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Forms SubsequentInvestment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Forms SubsequentInvestment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Forms SubsequentInvestment { get; init; } 
    #else
    public Forms SubsequentInvestment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a subscription or a redemption can be instructed by amount.
    /// </summary>
    [IsoId("_UBFN2Np-Ed-ak6NoX_4Aeg_1459492426")]
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
    [IsoId("_UBFN2dp-Ed-ak6NoX_4Aeg_1345653360")]
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
    /// Specifies the location of the main fund order desk.
    /// </summary>
    [IsoId("_UBFN2tp-Ed-ak6NoX_4Aeg_-483429979")]
    [DisplayName("Main Fund Order Desk Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainFndOrdrDskLctn")]
    #endif
    [IsoXmlTag("MainFndOrdrDskLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MainFundOrderDeskLocation1 MainFundOrderDeskLocation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MainFundOrderDeskLocation1 MainFundOrderDeskLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MainFundOrderDeskLocation1 MainFundOrderDeskLocation { get; init; } 
    #else
    public MainFundOrderDeskLocation1 MainFundOrderDeskLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Last date/time at which an order to subscribe or redeem can be given.
    /// </summary>
    [IsoId("_UBOXwNp-Ed-ak6NoX_4Aeg_-534652280")]
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
    [IsoId("_UBOXwdp-Ed-ak6NoX_4Aeg_-648491346")]
    [DisplayName("Dealing Cut Off Time Frame")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgCutOffTmFrame")]
    #endif
    [IsoXmlTag("DealgCutOffTmFrame")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TimeFrame3 DealingCutOffTimeFrame { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TimeFrame3 DealingCutOffTimeFrame { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame3 DealingCutOffTimeFrame { get; init; } 
    #else
    public TimeFrame3 DealingCutOffTimeFrame { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency at which the subscriptions are done.
    /// </summary>
    [IsoId("_UBOXwtp-Ed-ak6NoX_4Aeg_689276219")]
    [DisplayName("Dealing Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgFrqcy")]
    #endif
    [IsoXmlTag("DealgFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required EventFrequency5Code DealingFrequency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required EventFrequency5Code DealingFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency5Code DealingFrequency { get; init; } 
    #else
    public EventFrequency5Code DealingFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Description of frequency at which the subscription is done.
    /// </summary>
    [IsoId("_UBOXw9p-Ed-ak6NoX_4Aeg_689276281")]
    [DisplayName("Dealing Frequency Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgFrqcyDesc")]
    #endif
    [IsoXmlTag("DealgFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text DealingFrequencyDescription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DealingFrequencyDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DealingFrequencyDescription { get; init; } 
    #else
    public System.String DealingFrequencyDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Specific period, eg, for some guaranteed funds, during which the units/shares may be redeemed.
    /// </summary>
    [IsoId("_UBOXxNp-Ed-ak6NoX_4Aeg_689276403")]
    [DisplayName("Limited Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtdPrd")]
    #endif
    [IsoXmlTag("LtdPrd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? LimitedPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LimitedPeriod { get; init; } 
    #else
    public System.String? LimitedPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Enter the last business day following the day on which a subscription order is priced (T) by which settlement will be due
    /// for orders placed with the main Fund Order Desk, eg. T+3. Enter &quot;P&quot; (pre-payment) if cleared funds may be required before a
    /// subscription order can be executed.
    /// </summary>
    [IsoId("_UBOXxdp-Ed-ak6NoX_4Aeg_-1709843305")]
    [DisplayName("Settlement Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCycl")]
    #endif
    [IsoXmlTag("SttlmCycl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TimeFrame5Choice_ SettlementCycle { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TimeFrame5Choice_ SettlementCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame5Choice_ SettlementCycle { get; init; } 
    #else
    public TimeFrame5Choice_ SettlementCycle { get; set; } 
    #endif
    
    
    #nullable disable
    
}
