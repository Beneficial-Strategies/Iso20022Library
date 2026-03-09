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
[IsoId("_kmRxME96EeePXdaAO32Uew")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction94
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction94 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction94( ReconciliationFunction1Code reqReconciliationFunction,CardServiceType4Code reqReconciliationType )
    {
        ReconciliationFunction = reqReconciliationFunction;
        ReconciliationType = reqReconciliationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of reconciliation.
    /// </summary>
    [IsoId("_JkyXAfGIEeiGNursv3uE_g")]
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
    /// Type of reconciliation.
    /// </summary>
    [IsoId("_EYKmwE-BEeePXdaAO32Uew")]
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
    [IsoId("_cFV70E-DEeePXdaAO32Uew")]
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
    [IsoId("_E5zEAFAMEeedyPuM0kK2EQ")]
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
    [IsoId("_--3oMcybEeiqqJhU2tqK8A")]
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
    [IsoId("_BWEP0FASEeedyPuM0kK2EQ")]
    [DisplayName("Reconciliation Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnTtls")]
    #endif
    [IsoXmlTag("RcncltnTtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionTotals11? ReconciliationTotals { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTotals11? ReconciliationTotals { get; init; } 
    #else
    public TransactionTotals11? ReconciliationTotals { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_NVFkYvF-EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFees")]
    #endif
    [IsoXmlTag("AddtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? AdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? AdditionalFees { get; init; } 
    #else
    public AdditionalFee1? AdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_pq5o0RqnEeqH1IQNpbVpEw")]
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
