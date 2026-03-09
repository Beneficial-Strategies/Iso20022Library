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
/// Payments to and from a concentration bank account of a central counterparty.
/// </summary>
[IsoId("_1Qaz8LIhEeaYqc4G3TTwhA")]
[DisplayName("Flows")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Flows1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Flows1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Flows1( AmountAndDirection102 reqPaymentBankFlows,AmountAndDirection102 reqInvestmentFlows )
    {
        PaymentBankFlows = reqPaymentBankFlows;
        InvestmentFlows = reqInvestmentFlows;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Gross value of flows between the concentration bank account and accounts held at payment banks.
    /// </summary>
    [IsoId("_MPHTABXoEeejf-cbr8l5qw")]
    [DisplayName("Payment Bank Flows")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtBkFlows")]
    #endif
    [IsoXmlTag("PmtBkFlows")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 PaymentBankFlows { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 PaymentBankFlows { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 PaymentBankFlows { get; init; } 
    #else
    public AmountAndDirection102 PaymentBankFlows { get; set; } 
    #endif
    
    /// <summary>
    /// Gross value of flows between the concentration bank account and investment counterparties in respect of maturing investments and any other flows in / out of the concentration account.
    /// </summary>
    [IsoId("_YT2QMBXoEeejf-cbr8l5qw")]
    [DisplayName("Investment Flows")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtFlows")]
    #endif
    [IsoXmlTag("InvstmtFlows")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 InvestmentFlows { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 InvestmentFlows { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 InvestmentFlows { get; init; } 
    #else
    public AmountAndDirection102 InvestmentFlows { get; set; } 
    #endif
    
    
    #nullable disable
    
}
