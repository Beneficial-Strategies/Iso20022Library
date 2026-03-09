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
/// Breakdown of the transaction amount.
/// </summary>
[IsoId("_D_tC8ESKEeeb1MmUPTrSMw")]
[DisplayName("Detailed Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DetailedAmount19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DetailedAmount19 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DetailedAmount19( DetailAmount1Code reqType,Amount5 reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type or class of amount.
    /// </summary>
    [IsoId("_YcPYkESKEeeb1MmUPTrSMw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DetailAmount1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DetailAmount1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailAmount1Code Type { get; init; } 
    #else
    public DetailAmount1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information to specify the type of amount.
    /// </summary>
    [IsoId("_hhfF0ESKEeeb1MmUPTrSMw")]
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
    /// Detailed amount expressed in the transaction currency.
    /// </summary>
    [IsoId("_0-AI4ESKEeeb1MmUPTrSMw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Amount5 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Amount5 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount5 Amount { get; init; } 
    #else
    public Amount5 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed amount expressed in the cardholder billing currency.
    /// </summary>
    [IsoId("_G2Ww8ZKhEempjNUC7bi_Ng")]
    [DisplayName("Cardholder Billing Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrBllgAmt")]
    #endif
    [IsoXmlTag("CrdhldrBllgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount5? CardholderBillingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount5? CardholderBillingAmount { get; init; } 
    #else
    public Amount5? CardholderBillingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed amount expressed in the reconciliation currency. 
    /// </summary>
    [IsoId("_abQ7AZKhEempjNUC7bi_Ng")]
    [DisplayName("Reconciliation Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnAmt")]
    #endif
    [IsoXmlTag("RcncltnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount5? ReconciliationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount5? ReconciliationAmount { get; init; } 
    #else
    public Amount5? ReconciliationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Short description of the detailed amount.
    /// </summary>
    [IsoId("__X7xIESKEeeb1MmUPTrSMw")]
    [DisplayName("Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Labl")]
    #endif
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Label { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Label { get; init; } 
    #else
    public System.String? Label { get; set; } 
    #endif
    
    
    #nullable disable
    
}
