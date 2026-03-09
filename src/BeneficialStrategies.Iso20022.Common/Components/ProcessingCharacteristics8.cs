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
/// Processing characteristics linked to a subscription to an investment fund or alternative/hedge fund.
/// </summary>
[IsoId("_IkoaAbnxEeq5Lv5RTGDs7Q")]
[DisplayName("Processing Characteristics")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProcessingCharacteristics8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency in which a subscription is accepted.
    /// </summary>
    [IsoId("_I4tzpbnxEeq5Lv5RTGDs7Q")]
    [DisplayName("Dealing Currency Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgCcyAccptd")]
    #endif
    [IsoXmlTag("DealgCcyAccptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? DealingCurrencyAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? DealingCurrencyAccepted { get; init; } 
    #else
    public string? DealingCurrencyAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether an application form is required for the initial investment.
    /// </summary>
    [IsoId("_I4tzp7nxEeq5Lv5RTGDs7Q")]
    [DisplayName("Initial Investment Application")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlInvstmtAppl")]
    #endif
    [IsoXmlTag("InitlInvstmtAppl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Forms1? InitialInvestmentApplication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Forms1? InitialInvestmentApplication { get; init; } 
    #else
    public Forms1? InitialInvestmentApplication { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether an application form is required for the subsequent investments.
    /// </summary>
    [IsoId("_I4tzqbnxEeq5Lv5RTGDs7Q")]
    [DisplayName("Subsequent Investment Application")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbsqntInvstmtAppl")]
    #endif
    [IsoXmlTag("SbsqntInvstmtAppl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Forms1? SubsequentInvestmentApplication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Forms1? SubsequentInvestmentApplication { get; init; } 
    #else
    public Forms1? SubsequentInvestmentApplication { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a subscription can be instructed by amount.
    /// </summary>
    [IsoId("_I4tzq7nxEeq5Lv5RTGDs7Q")]
    [DisplayName("Amount Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtInd")]
    #endif
    [IsoXmlTag("AmtInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AmountIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AmountIndicator { get; init; } 
    #else
    public System.String? AmountIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a subscription can be instructed as a number of units.
    /// </summary>
    [IsoId("_I4tzrbnxEeq5Lv5RTGDs7Q")]
    [DisplayName("Units Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitsInd")]
    #endif
    [IsoXmlTag("UnitsInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? UnitsIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnitsIndicator { get; init; } 
    #else
    public System.String? UnitsIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the rounding direction applied to nearest unit.
    /// </summary>
    [IsoId("_I4tzr7nxEeq5Lv5RTGDs7Q")]
    [DisplayName("Rounding")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rndg")]
    #endif
    [IsoXmlTag("Rndg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingDirection2Code? Rounding { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingDirection2Code? Rounding { get; init; } 
    #else
    public RoundingDirection2Code? Rounding { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the main fund order desk.
    /// </summary>
    [IsoId("_I4tzsbnxEeq5Lv5RTGDs7Q")]
    [DisplayName("Main Fund Order Desk Location")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainFndOrdrDskLctn")]
    #endif
    [IsoXmlTag("MainFndOrdrDskLctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; init; } 
    #else
    public MainFundOrderDeskLocation1? MainFundOrderDeskLocation { get; set; } 
    #endif
    
    /// <summary>
    /// Frequency at which the subscriptions are done.
    /// </summary>
    [IsoId("_I4tzs7nxEeq5Lv5RTGDs7Q")]
    [DisplayName("Dealing Frequency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgFrqcy")]
    #endif
    [IsoXmlTag("DealgFrqcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventFrequency5Code? DealingFrequency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventFrequency5Code? DealingFrequency { get; init; } 
    #else
    public EventFrequency5Code? DealingFrequency { get; set; } 
    #endif
    
    /// <summary>
    /// Description of frequency at which the subscription is done.
    /// </summary>
    [IsoId("_I4tztbnxEeq5Lv5RTGDs7Q")]
    [DisplayName("Dealing Frequency Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgFrqcyDesc")]
    #endif
    [IsoXmlTag("DealgFrqcyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? DealingFrequencyDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DealingFrequencyDescription { get; init; } 
    #else
    public System.String? DealingFrequencyDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Latest time at which an order to subscribe can be given.
    /// </summary>
    [IsoId("_I4tzt7nxEeq5Lv5RTGDs7Q")]
    [DisplayName("Dealing Cut Off Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgCutOffTm")]
    #endif
    [IsoXmlTag("DealgCutOffTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? DealingCutOffTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? DealingCutOffTime { get; init; } 
    #else
    public System.TimeOnly? DealingCutOffTime { get; set; } 
    #endif
    
    /// <summary>
    /// Dealing cut-off timeframe.
    /// </summary>
    [IsoId("_I4tzubnxEeq5Lv5RTGDs7Q")]
    [DisplayName("Dealing Cut Off Time Frame")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgCutOffTmFrame")]
    #endif
    [IsoXmlTag("DealgCutOffTmFrame")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeFrame4? DealingCutOffTimeFrame { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame4? DealingCutOffTimeFrame { get; init; } 
    #else
    public TimeFrame4? DealingCutOffTimeFrame { get; set; } 
    #endif
    
    /// <summary>
    /// Time at which the deal confirmation is issued.
    /// </summary>
    [IsoId("_I4tzu7nxEeq5Lv5RTGDs7Q")]
    [DisplayName("Deal Confirmation Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealConfTm")]
    #endif
    [IsoXmlTag("DealConfTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? DealConfirmationTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? DealConfirmationTime { get; init; } 
    #else
    public System.TimeOnly? DealConfirmationTime { get; set; } 
    #endif
    
    /// <summary>
    /// Time frame within which the deal confirmation is issued.
    /// </summary>
    [IsoId("_I4tzvbnxEeq5Lv5RTGDs7Q")]
    [DisplayName("Deal Confirmation Time Frame")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealConfTmFrame")]
    #endif
    [IsoXmlTag("DealConfTmFrame")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeFrame7? DealConfirmationTimeFrame { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame7? DealConfirmationTimeFrame { get; init; } 
    #else
    public TimeFrame7? DealConfirmationTimeFrame { get; set; } 
    #endif
    
    /// <summary>
    /// Specific period, for example, for some guaranteed funds, during which the units/shares may be subscribed.
    /// </summary>
    [IsoId("_I4tzv7nxEeq5Lv5RTGDs7Q")]
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
    /// Settlement timing.
    /// </summary>
    [IsoId("_I4tzwbnxEeq5Lv5RTGDs7Q")]
    [DisplayName("Settlement Cycle")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCycl")]
    #endif
    [IsoXmlTag("SttlmCycl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TimeFrame7Choice_? SettlementCycle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TimeFrame7Choice_? SettlementCycle { get; init; } 
    #else
    public TimeFrame7Choice_? SettlementCycle { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the subscription processing characteristics.
    /// </summary>
    [IsoId("_I4tzw7nxEeq5Lv5RTGDs7Q")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
