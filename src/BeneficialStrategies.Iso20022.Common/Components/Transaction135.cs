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
/// Reconciliation transaction
/// </summary>
[IsoId("_onnzYYv9EeuC5632vxUfGg")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction135
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction135 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction135( ReconciliationFunction1Code reqReconciliationFunction,CardServiceType4Code reqReconciliationType )
    {
        ReconciliationFunction = reqReconciliationFunction;
        ReconciliationType = reqReconciliationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of reconciliation.
    /// </summary>
    [IsoId("_otJMkYv9EeuC5632vxUfGg")]
    [DisplayName("Reconciliation Function")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnFctn")]
    #endif
    [IsoXmlTag("RcncltnFctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReconciliationFunction1Code ReconciliationFunction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReconciliationFunction1Code ReconciliationFunction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationFunction1Code ReconciliationFunction { get; init; } 
    #else
    public ReconciliationFunction1Code ReconciliationFunction { get; set; } 
    #endif
    
    /// <summary>
    /// A code to indicate the activity type to be reconciled.
    /// </summary>
    [IsoId("_EYGlACX_Eeym0KcvJF9aDQ")]
    [DisplayName("Reconciliation Activity Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnActvtyTp")]
    #endif
    [IsoXmlTag("RcncltnActvtyTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReconciliationActivityType1Code? ReconciliationActivityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationActivityType1Code? ReconciliationActivityType { get; init; } 
    #else
    public ReconciliationActivityType1Code? ReconciliationActivityType { get; set; } 
    #endif
    
    /// <summary>
    /// Other reconciliation activity type defined at private or national level
    /// </summary>
    [IsoId("_MDkJ8CYBEeym0KcvJF9aDQ")]
    [DisplayName("Other Reconciliation Activity Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRcncltnActvtyTp")]
    #endif
    [IsoXmlTag("OthrRcncltnActvtyTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherReconciliationActivityType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherReconciliationActivityType { get; init; } 
    #else
    public System.String? OtherReconciliationActivityType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of reconciliation.
    /// </summary>
    [IsoId("_otJMk4v9EeuC5632vxUfGg")]
    [DisplayName("Reconciliation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnTp")]
    #endif
    [IsoXmlTag("RcncltnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardServiceType4Code ReconciliationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardServiceType4Code ReconciliationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardServiceType4Code ReconciliationType { get; init; } 
    #else
    public CardServiceType4Code ReconciliationType { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of reconciliation.
    /// </summary>
    [IsoId("_otJMlYv9EeuC5632vxUfGg")]
    [DisplayName("Other Reconciliation Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrRcncltnTp")]
    #endif
    [IsoXmlTag("OthrRcncltnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherReconciliationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherReconciliationType { get; init; } 
    #else
    public System.String? OtherReconciliationType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_otJMl4v9EeuC5632vxUfGg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification12? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested currency by the acceptor.
    /// ISO 4217
    /// </summary>
    [IsoId("_otJMmYv9EeuC5632vxUfGg")]
    [DisplayName("Requested Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdCcy")]
    #endif
    [IsoXmlTag("ReqdCcy")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? RequestedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestedCurrency { get; init; } 
    #else
    public System.String? RequestedCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Totals of the reconciliation.
    /// </summary>
    [IsoId("_otJMm4v9EeuC5632vxUfGg")]
    [DisplayName("Reconciliation Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnTtls")]
    #endif
    [IsoXmlTag("RcncltnTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionTotals13? ReconciliationTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotals13? ReconciliationTotals { get; init; } 
    #else
    public TransactionTotals13? ReconciliationTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_otJzoYv9EeuC5632vxUfGg")]
    [DisplayName("Additional Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFee")]
    #endif
    [IsoXmlTag("AddtlFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee2? AdditionalFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee2? AdditionalFee { get; init; } 
    #else
    public AdditionalFee2? AdditionalFee { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_otJzo4v9EeuC5632vxUfGg")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
