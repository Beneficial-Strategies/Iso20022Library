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
/// Total of credit or debit transactions.
/// </summary>
[IsoId("_xVxxEXu-EeSLmfFG0DG7zQ")]
[DisplayName("Transaction Totals")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionTotals5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionTotals5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionTotals5( ImpliedCurrencyAndAmount reqAmount,System.UInt64 reqNumber,ImpliedCurrencyAndAmount reqChargeBackAmount,System.UInt64 reqChargeBackNumber,ImpliedCurrencyAndAmount reqReversalAmount,System.UInt64 reqReversalNumber )
    {
        Amount = reqAmount;
        Number = reqNumber;
        ChargeBackAmount = reqChargeBackAmount;
        ChargeBackNumber = reqChargeBackNumber;
        ReversalAmount = reqReversalAmount;
        ReversalNumber = reqReversalNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// </summary>
    [IsoId("_FRyMgHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Number of all financial transactions.
    /// </summary>
    [IsoId("_Jv4vgHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Number { get; init; } 
    #else
    public System.UInt64 Number { get; set; } 
    #endif
    
    /// <summary>
    /// Cumulative amount of all chargeback transactions exclusive of any fees.
    /// </summary>
    [IsoId("_OZXcEHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Charge Back Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBckAmt")]
    #endif
    [IsoXmlTag("ChrgBckAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount ChargeBackAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount ChargeBackAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount ChargeBackAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount ChargeBackAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of chargeback transactions.
    /// </summary>
    [IsoId("_RTCX4Hu_EeSLmfFG0DG7zQ")]
    [DisplayName("Charge Back Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBckNb")]
    #endif
    [IsoXmlTag("ChrgBckNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber ChargeBackNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ChargeBackNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ChargeBackNumber { get; init; } 
    #else
    public System.UInt64 ChargeBackNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Cumulative amount of all reversal transactions exclusive of any fees.
    /// </summary>
    [IsoId("_WkGo4Hu_EeSLmfFG0DG7zQ")]
    [DisplayName("Reversal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslAmt")]
    #endif
    [IsoXmlTag("RvslAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount ReversalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount ReversalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount ReversalAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount ReversalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of reversal transactions.
    /// </summary>
    [IsoId("_ZPLIAHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Reversal Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RvslNb")]
    #endif
    [IsoXmlTag("RvslNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber ReversalNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 ReversalNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 ReversalNumber { get; init; } 
    #else
    public System.UInt64 ReversalNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Sum amount of all fees.
    /// </summary>
    [IsoId("_efytEHu_EeSLmfFG0DG7zQ")]
    [DisplayName("Fee Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FeeAmts")]
    #endif
    [IsoXmlTag("FeeAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? FeeAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? FeeAmounts { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? FeeAmounts { get; set; } 
    #endif
    
    
    #nullable disable
    
}
