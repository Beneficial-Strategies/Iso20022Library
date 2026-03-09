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
/// Data to request a Reversal.
/// </summary>
[IsoId("_aWvZcS8QEeu125Ip9zFcsQ")]
[DisplayName("Reversal Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalRequest3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReversalRequest3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalRequest3( ReversalReason1Code reqReversalReason )
    {
        ReversalReason = reqReversalReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Transaction to reverse.
    /// </summary>
    [IsoId("_ah5gkS8QEeu125Ip9zFcsQ")]
    [DisplayName("Reversal Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslTx")]
    #endif
    [IsoXmlTag("RvslTx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction110? ReversalTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction110? ReversalTransaction { get; init; } 
    #else
    public CardPaymentTransaction110? ReversalTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_IS6LIS8REeu125Ip9zFcsQ")]
    [DisplayName("Loyalty Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyData")]
    #endif
    [IsoXmlTag("LltyData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyRequestData2? LoyaltyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyRequestData2? LoyaltyData { get; init; } 
    #else
    public LoyaltyRequestData2? LoyaltyData { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for this reversal.
    /// </summary>
    [IsoId("_ah5gky8QEeu125Ip9zFcsQ")]
    [DisplayName("Reversal Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslRsn")]
    #endif
    [IsoXmlTag("RvslRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReversalReason1Code ReversalReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReversalReason1Code ReversalReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalReason1Code ReversalReason { get; init; } 
    #else
    public ReversalReason1Code ReversalReason { get; set; } 
    #endif
    
    /// <summary>
    /// Amount to reverse (total or partial).
    /// </summary>
    [IsoId("_ah5glS8QEeu125Ip9zFcsQ")]
    [DisplayName("Reversed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvsdAmt")]
    #endif
    [IsoXmlTag("RvsdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? ReversedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specific Customer Order linked with the reversal.
    /// </summary>
    [IsoId("_ah5gly8QEeu125Ip9zFcsQ")]
    [DisplayName("Customer Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrOrdr")]
    #endif
    [IsoXmlTag("CstmrOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerOrder1? CustomerOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerOrder1? CustomerOrder { get; init; } 
    #else
    public CustomerOrder1? CustomerOrder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
