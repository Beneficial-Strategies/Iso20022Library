// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation transaction between an acceptor and an acquirer.
/// </summary>
[IsoId("_TGcRVgEcEeCQm6a_G2yO_w_744459004")]
[DisplayName("Transaction Reconciliation")]
public partial record TransactionReconciliation1
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the transaction requires a closure of the reconciliation period.
    /// </summary>
    [IsoId("_TGcRVwEcEeCQm6a_G2yO_w_-121603655")]
    [DisplayName("Close Period")]
    [IsoXmlTag("ClsPrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ClosePeriod { get; init; } 
    
    /// <summary>
    /// Unique identification of a reconciliation transaction.
    /// </summary>
    [IsoId("_TGcRWAEcEeCQm6a_G2yO_w_-1610367733")]
    [DisplayName("Reconciliation Transaction Identification")]
    [IsoXmlTag("RcncltnTxId")]
    public required TransactionIdentifier1 ReconciliationTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_TGcRWQEcEeCQm6a_G2yO_w_-1053540175")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Transaction totals during the reconciliation period for a certain type of transaction.
    /// </summary>
    [IsoId("_TGcRWgEcEeCQm6a_G2yO_w_1177771040")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public ValueList<TransactionTotals1> TransactionTotals { get; init; } = [];
    // ID for the above is _TGcRWgEcEeCQm6a_G2yO_w_1177771040
    
    /// <summary>
    /// Additional information related to the reconciliation transaction.
    /// </summary>
    [IsoId("_TGcRWwEcEeCQm6a_G2yO_w_961666325")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalTransactionData { get; init; } 
    
    
    #nullable disable
    
}
