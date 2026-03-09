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
/// Contains additional fee reconciliation data.
/// </summary>
[IsoId("_fULtkaIAEeuiuNcvKhXmNQ")]
[DisplayName("Additional Fee Reconciliation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalFeeReconciliation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalFeeReconciliation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalFeeReconciliation2( ReconciliationImpact1Code reqReconciliationImpact,TypeOfAmount21Code reqType,ImpliedCurrencyAndAmount reqAmount,System.UInt64 reqCount )
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
    [IsoId("_fZQa0aIAEeuiuNcvKhXmNQ")]
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
    /// contains the list of additional fee types.
    /// </summary>
    [IsoId("_fZQa06IAEeuiuNcvKhXmNQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TypeOfAmount21Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TypeOfAmount21Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount21Code Type { get; init; } 
    #else
    public TypeOfAmount21Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other amount type defined at national or private level.
    /// </summary>
    [IsoId("_fZQa1aIAEeuiuNcvKhXmNQ")]
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
    /// ISO 8583:87 bit 82, 83, 84 &amp; 85
    /// ISO 8583:93/2003 bit 109 &amp; 110
    /// </summary>
    [IsoId("_fZQa16IAEeuiuNcvKhXmNQ")]
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
    /// </summary>
    [IsoId("_fZQa2aIAEeuiuNcvKhXmNQ")]
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
