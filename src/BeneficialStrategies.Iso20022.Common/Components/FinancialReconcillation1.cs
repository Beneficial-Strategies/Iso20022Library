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
/// Contains financial reconciliation data.
/// </summary>
[IsoId("_OeFcWcypEeiqqJhU2tqK8A")]
[DisplayName("Financial Reconcillation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialReconcillation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialReconcillation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialReconcillation1( ReconciliationImpact1Code reqReconciliationImpact,ReconciliationCategory1Code reqType,ImpliedCurrencyAndAmount reqAmount,System.UInt64 reqCount )
    {
        ReconciliationImpact = reqReconciliationImpact;
        Type = reqType;
        Amount = reqAmount;
        Count = reqCount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reconciliation credit or debit indicator.
    /// </summary>
    [IsoId("_OeGDY8ypEeiqqJhU2tqK8A")]
    [DisplayName("Reconciliation Impact")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnImpct")]
    #endif
    [IsoXmlTag("RcncltnImpct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationImpact1Code ReconciliationImpact { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationImpact1Code ReconciliationImpact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationImpact1Code ReconciliationImpact { get; init; } 
    #else
    public ReconciliationImpact1Code ReconciliationImpact { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the reconciliation category.
    /// </summary>
    [IsoId("_OeGDZcypEeiqqJhU2tqK8A")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationCategory1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationCategory1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationCategory1Code Type { get; init; } 
    #else
    public ReconciliationCategory1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other reconciliation category defined at national or private level.
    /// </summary>
    [IsoId("_OeGDYcypEeiqqJhU2tqK8A")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Cumulative amount of all financial transactions.
    /// ISO 8583:87 bit 86,87,88 &amp; 89
    /// ISO 8583:93 bit 86,87,88 ,89,105 &amp; 106
    /// ISO 8583:2003 bit 74-1,74-3,74-5,74-7,74-9 &amp; 74-11
    /// </summary>
    [IsoId("_OeGDZMypEeiqqJhU2tqK8A")]
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
    /// Number of transactions.
    /// ISO 8583:87 bit 74, 75, 76, 77, 78, 79 &amp; 81
    /// ISO 8583:93 bit 74, 75, 76, 77, 78, 79, 80, 81, 83, 84, 85, 90, 107 &amp; 108
    /// ISO 8583:2003 bit 74-2, 74-4, 74-6, 74-8, 74-10, 74-12, 75-1, 75-2, 75-4, 75-5, 75-6, 76-7, 75-8 &amp; 75-9
    /// </summary>
    [IsoId("_hSSlYcytEeiqqJhU2tqK8A")]
    [DisplayName("Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnt")]
    #endif
    [IsoXmlTag("Cnt")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Count { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Count { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Count { get; init; } 
    #else
    public System.UInt64 Count { get; set; } 
    #endif
    
    
    #nullable disable
    
}
