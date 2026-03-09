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
/// Instrument used to process a payment instruction.
/// </summary>
[IsoId("__Ai3oCC0EeWJd9HF2tO7BA")]
[DisplayName("Payment Instrument")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstrument13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInstrument13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInstrument13( string reqSettlementCurrency )
    {
        SettlementCurrency = reqSettlementCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_Hmk5USC1EeWJd9HF2tO7BA")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SettlementCurrency { get; init; } 
    #else
    public string SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of the dividend payment not to be reinvested, that is, to be paid in cash.
    /// </summary>
    [IsoId("_LAh3sSC1EeWJd9HF2tO7BA")]
    [DisplayName("Dividend Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddPctg")]
    #endif
    [IsoXmlTag("DvddPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageBoundedRate? DividendPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? DividendPercentage { get; init; } 
    #else
    public System.Decimal? DividendPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [IsoId("_q1v80SC1EeWJd9HF2tO7BA")]
    [DisplayName("Subscription Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPmtInstrm")]
    #endif
    [IsoXmlTag("SbcptPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument18Choice_? SubscriptionPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument18Choice_? SubscriptionPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument18Choice_? SubscriptionPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    [IsoId("_CUs6kSC2EeWJd9HF2tO7BA")]
    [DisplayName("Redemption Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPmtInstrm")]
    #endif
    [IsoXmlTag("RedPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument19Choice_? RedemptionPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument19Choice_? RedemptionPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument19Choice_? RedemptionPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [IsoId("_OMg2ESC2EeWJd9HF2tO7BA")]
    [DisplayName("Dividend Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddPmtInstrm")]
    #endif
    [IsoXmlTag("DvddPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument19Choice_? DividendPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument19Choice_? DividendPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument19Choice_? DividendPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [IsoId("_TWp_sSC2EeWJd9HF2tO7BA")]
    [DisplayName("Savings Plan Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvgsPlanPmtInstrm")]
    #endif
    [IsoXmlTag("SvgsPlanPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument18Choice_? SavingsPlanPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument18Choice_? SavingsPlanPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument18Choice_? SavingsPlanPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for an interest payment.
    /// </summary>
    [IsoId("_YE0X8SC2EeWJd9HF2tO7BA")]
    [DisplayName("Interest Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmtInstrm")]
    #endif
    [IsoXmlTag("IntrstPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument19Choice_? InterestPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument19Choice_? InterestPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument19Choice_? InterestPaymentInstrument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
