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
/// Totals of the reconciliation.
/// </summary>
[IsoId("_QtX6MZMjEeuleeHpFMMhmQ")]
[DisplayName("Transaction Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionTotals13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionTotals13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionTotals13( System.String reqCurrency )
    {
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and identification of reconciliation.
    /// </summary>
    [IsoId("_Q0DxAZMjEeuleeHpFMMhmQ")]
    [DisplayName("Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rcncltn")]
    #endif
    [IsoXmlTag("Rcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reconciliation3? Reconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reconciliation3? Reconciliation { get; init; } 
    #else
    public Reconciliation3? Reconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Total of credit transactions.
    /// </summary>
    [IsoId("_Q0DxA5MjEeuleeHpFMMhmQ")]
    [DisplayName("Financial Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinRcncltn")]
    #endif
    [IsoXmlTag("FinRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialReconciliation2? FinancialReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialReconciliation2? FinancialReconciliation { get; init; } 
    #else
    public FinancialReconciliation2? FinancialReconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains total message count.
    /// </summary>
    [IsoId("_Q0DxBZMjEeuleeHpFMMhmQ")]
    [DisplayName("Message Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRcncltn")]
    #endif
    [IsoXmlTag("MsgRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageReconciliation3? MessageReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageReconciliation3? MessageReconciliation { get; init; } 
    #else
    public MessageReconciliation3? MessageReconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional fee reconciliation data.
    /// </summary>
    [IsoId("_Q0DxB5MjEeuleeHpFMMhmQ")]
    [DisplayName("Additional Fee Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFeeRcncltn")]
    #endif
    [IsoXmlTag("AddtlFeeRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFeeReconciliation2? AdditionalFeeReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFeeReconciliation2? AdditionalFeeReconciliation { get; init; } 
    #else
    public AdditionalFeeReconciliation2? AdditionalFeeReconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the transaction.
    /// </summary>
    [IsoId("_Q0DxCZMjEeuleeHpFMMhmQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMin2Max3NumericText Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Currency { get; init; } 
    #else
    public System.String Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Net amount of reconciliation.
    /// ISO 8583:87/93 bit 97
    /// </summary>
    [IsoId("_Q0DxC5MjEeuleeHpFMMhmQ")]
    [DisplayName("Net Amount Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmtRcncltn")]
    #endif
    [IsoXmlTag("NetAmtRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount16? NetAmountReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount16? NetAmountReconciliation { get; init; } 
    #else
    public Amount16? NetAmountReconciliation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
