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
[IsoId("_mVydMVANEeedyPuM0kK2EQ")]
[DisplayName("Transaction Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionTotals11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionTotals11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionTotals11( System.String reqCurrency )
    {
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date and identification of reconciliation.
    /// </summary>
    [IsoId("_C-XcQcyfEeiqqJhU2tqK8A")]
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
    [IsoId("_mhPfQVANEeedyPuM0kK2EQ")]
    [DisplayName("Financial Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinRcncltn")]
    #endif
    [IsoXmlTag("FinRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialReconcillation1? FinancialReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialReconcillation1? FinancialReconciliation { get; init; } 
    #else
    public FinancialReconcillation1? FinancialReconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains total message count.
    /// </summary>
    [IsoId("_mhPfQ1ANEeedyPuM0kK2EQ")]
    [DisplayName("Message Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgRcncltn")]
    #endif
    [IsoXmlTag("MsgRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageReconcillation1? MessageReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageReconcillation1? MessageReconciliation { get; init; } 
    #else
    public MessageReconcillation1? MessageReconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional fee reconciliation data.
    /// </summary>
    [IsoId("_mhPfRVANEeedyPuM0kK2EQ")]
    [DisplayName("Additional Fee Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFeeRcncltn")]
    #endif
    [IsoXmlTag("AddtlFeeRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFeeReconciliation1? AdditionalFeeReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFeeReconciliation1? AdditionalFeeReconciliation { get; init; } 
    #else
    public AdditionalFeeReconciliation1? AdditionalFeeReconciliation { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the transaction.
    /// </summary>
    [IsoId("_y34jEcytEeiqqJhU2tqK8A")]
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
    [IsoId("_ixQ6Uc5ZEeiEmaZryQQ14Q")]
    [DisplayName("Net Amount Reconciliation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetAmtRcncltn")]
    #endif
    [IsoXmlTag("NetAmtRcncltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount5? NetAmountReconciliation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount5? NetAmountReconciliation { get; init; } 
    #else
    public Amount5? NetAmountReconciliation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
