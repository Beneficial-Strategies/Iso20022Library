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
/// Settlement instructions to be used to transfer cash from the debtor to the creditor.
/// </summary>
[IsoId("_bGuAQRRfEeOKWo1NF21OVw")]
[DisplayName("Investment Fund Cash Settlement Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundCashSettlementInformation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [IsoId("_bdx1YxRfEeOKWo1NF21OVw")]
    [DisplayName("Subscription Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbcptPmtInstrm")]
    #endif
    [IsoXmlTag("SbcptPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument11? SubscriptionPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument11? SubscriptionPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument11? SubscriptionPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a redemption payment.
    /// </summary>
    [IsoId("_bdx1ZRRfEeOKWo1NF21OVw")]
    [DisplayName("Redemption Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPmtInstrm")]
    #endif
    [IsoXmlTag("RedPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument12? RedemptionPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument12? RedemptionPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument12? RedemptionPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [IsoId("_bdx1ZxRfEeOKWo1NF21OVw")]
    [DisplayName("Dividend Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddPmtInstrm")]
    #endif
    [IsoXmlTag("DvddPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument12? DividendPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument12? DividendPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument12? DividendPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [IsoId("_bdx1aRRfEeOKWo1NF21OVw")]
    [DisplayName("Savings Plan Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvgsPlanPmtInstrm")]
    #endif
    [IsoXmlTag("SvgsPlanPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument11? SavingsPlanPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument11? SavingsPlanPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument11? SavingsPlanPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for an interest payment.
    /// </summary>
    [IsoId("_bdx1axRfEeOKWo1NF21OVw")]
    [DisplayName("Interest Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmtInstrm")]
    #endif
    [IsoXmlTag("IntrstPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument12? InterestPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument12? InterestPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument12? InterestPaymentInstrument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
