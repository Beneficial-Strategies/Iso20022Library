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
/// Reconciliation transaction between an acceptor and an acquirer.
/// </summary>
[IsoId("_TGcRVgEcEeCQm6a_G2yO_w_744459004")]
[DisplayName("Transaction Reconciliation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionReconciliation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionReconciliation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionReconciliation1( TransactionIdentifier1 reqReconciliationTransactionIdentification,System.String reqReconciliationIdentification )
    {
        ReconciliationTransactionIdentification = reqReconciliationTransactionIdentification;
        ReconciliationIdentification = reqReconciliationIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates if the transaction requires a closure of the reconciliation period.
    /// </summary>
    [IsoId("_TGcRVwEcEeCQm6a_G2yO_w_-121603655")]
    [DisplayName("Close Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsPrd")]
    #endif
    [IsoXmlTag("ClsPrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ClosePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosePeriod { get; init; } 
    #else
    public System.String? ClosePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of a reconciliation transaction.
    /// </summary>
    [IsoId("_TGcRWAEcEeCQm6a_G2yO_w_-1610367733")]
    [DisplayName("Reconciliation Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnTxId")]
    #endif
    [IsoXmlTag("RcncltnTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 ReconciliationTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 ReconciliationTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 ReconciliationTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 ReconciliationTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_TGcRWQEcEeCQm6a_G2yO_w_-1053540175")]
    [DisplayName("Reconciliation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnId")]
    #endif
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ReconciliationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ReconciliationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ReconciliationIdentification { get; init; } 
    #else
    public System.String ReconciliationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction totals during the reconciliation period for a certain type of transaction.
    /// </summary>
    [IsoId("_TGcRWgEcEeCQm6a_G2yO_w_1177771040")]
    [DisplayName("Transaction Totals")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTtls")]
    #endif
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals1> TransactionTotals { get; init; } = new ValueList<TransactionTotals1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _TGcRWgEcEeCQm6a_G2yO_w_1177771040
    
    /// <summary>
    /// Additional information related to the reconciliation transaction.
    /// </summary>
    [IsoId("_TGcRWwEcEeCQm6a_G2yO_w_961666325")]
    [DisplayName("Additional Transaction Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTxData")]
    #endif
    [IsoXmlTag("AddtlTxData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalTransactionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalTransactionData { get; init; } 
    #else
    public System.String? AdditionalTransactionData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
