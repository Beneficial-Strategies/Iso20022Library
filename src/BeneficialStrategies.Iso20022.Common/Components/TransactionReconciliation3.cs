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
[IsoId("_5HszwWl_EeSxgrJ0GX4SQQ")]
[DisplayName("Transaction Reconciliation")]
public partial record TransactionReconciliation3
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the transaction requires a closure of the reconciliation period.
    /// </summary>
    [IsoId("_5UzboWl_EeSxgrJ0GX4SQQ")]
    [DisplayName("Close Period")]
    [IsoXmlTag("ClsPrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ClosePeriod { get; init; } 
    
    /// <summary>
    /// Unique identification of a reconciliation transaction.
    /// </summary>
    [IsoId("_5Uzbo2l_EeSxgrJ0GX4SQQ")]
    [DisplayName("Reconciliation Transaction Identification")]
    [IsoXmlTag("RcncltnTxId")]
    public required TransactionIdentifier1 ReconciliationTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_5UzbpWl_EeSxgrJ0GX4SQQ")]
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Transaction totals during the reconciliation period for a certain type of transaction.
    /// </summary>
    [IsoId("_5Uzbp2l_EeSxgrJ0GX4SQQ")]
    [DisplayName("Transaction Totals")]
    [IsoXmlTag("TxTtls")]
    public TransactionTotals3? TransactionTotals { get; init; } 
    
    /// <summary>
    /// Additional information related to the reconciliation transaction.
    /// </summary>
    [IsoId("_5UzbqWl_EeSxgrJ0GX4SQQ")]
    [DisplayName("Additional Transaction Data")]
    [IsoXmlTag("AddtlTxData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalTransactionData { get; init; } 
    
    
    #nullable disable
    
}
