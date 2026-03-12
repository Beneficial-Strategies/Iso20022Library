// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response Data to a Reversal request.
/// </summary>
[IsoId("_vGMJ4U37Eey_VecAUE-C9Q")]
[DisplayName("Reversal Response")]
public partial record ReversalResponse6
{
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_vMniAU37Eey_VecAUE-C9Q")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; } 
    
    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_vMniA037Eey_VecAUE-C9Q")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; } 
    
    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_vMniBU37Eey_VecAUE-C9Q")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_vMniB037Eey_VecAUE-C9Q")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_vMniCU37Eey_VecAUE-C9Q")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? IssuerReferenceData { get; init; } 
    
    /// <summary>
    /// Result of reversal transaction.
    /// </summary>
    [IsoId("_vMniC037Eey_VecAUE-C9Q")]
    [DisplayName("Reversal Transaction Result")]
    [IsoXmlTag("RvslTxRslt")]
    public required RetailerReversalResult4 ReversalTransactionResult { get; init; } 
    
    /// <summary>
    /// Amount that have been reverse.
    /// </summary>
    [IsoId("_vMniDU37Eey_VecAUE-C9Q")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    
    /// <summary>
    /// Various receipts linked to the reversal.
    /// </summary>
    [IsoId("_vMniD037Eey_VecAUE-C9Q")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt4? Receipt { get; init; } 
    
    
    #nullable disable
    
}
