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
/// Settlement instructions to be used to transfer cash from the Debtor to the Creditor.
/// </summary>
[IsoId("_FtnioRQwEeKebsB9eKJSkA")]
[DisplayName("Investment Fund Cash Settlement Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundCashSettlementInformation6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentFundCashSettlementInformation6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentFundCashSettlementInformation6( DataModification2Code reqModificationScopeIndication )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied on a set of information.
    /// </summary>
    [IsoId("_GDhhNRQwEeKebsB9eKJSkA")]
    [DisplayName("Modification Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModScpIndctn")]
    #endif
    [IsoXmlTag("ModScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification2Code ModificationScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification2Code ModificationScopeIndication { get; init; } 
    #else
    public DataModification2Code ModificationScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a subscription payment.
    /// </summary>
    [IsoId("_GDhhORQwEeKebsB9eKJSkA")]
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
    [IsoId("_GDhhPRQwEeKebsB9eKJSkA")]
    [DisplayName("Redemption Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPmtInstrm")]
    #endif
    [IsoXmlTag("RedPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument10? RedemptionPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument10? RedemptionPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument10? RedemptionPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a dividend payment.
    /// </summary>
    [IsoId("_GDhhQRQwEeKebsB9eKJSkA")]
    [DisplayName("Dividend Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddPmtInstrm")]
    #endif
    [IsoXmlTag("DvddPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument10? DividendPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument10? DividendPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument10? DividendPaymentInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Instrument that has or represents monetary value and is used to process a payment instruction for a savings plan payment.
    /// </summary>
    [IsoId("_GDhhRRQwEeKebsB9eKJSkA")]
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
    [IsoId("_EZkg1RQwEeKebsB9eKJSkA")]
    [DisplayName("Interest Payment Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmtInstrm")]
    #endif
    [IsoXmlTag("IntrstPmtInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentInstrument10? InterestPaymentInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstrument10? InterestPaymentInstrument { get; init; } 
    #else
    public PaymentInstrument10? InterestPaymentInstrument { get; set; } 
    #endif
    
    
    #nullable disable
    
}
