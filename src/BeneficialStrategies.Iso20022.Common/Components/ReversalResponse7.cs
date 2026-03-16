// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response data to a reversal request.
/// </summary>
[IsoId("_rmG4YXHBEe2TbaNWBpRZpQ")]
[DisplayName("Reversal Response")]
public record ReversalResponse7
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_rsS_8XHBEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_rsS_83HBEe2TbaNWBpRZpQ")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_rsS_9XHBEe2TbaNWBpRZpQ")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_rsS_93HBEe2TbaNWBpRZpQ")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_rsS_-XHBEe2TbaNWBpRZpQ")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Result of reversal transaction.
    /// </summary>
    [IsoId("_rsS_-3HBEe2TbaNWBpRZpQ")]
    [DisplayName("Reversal Transaction Result")]
    [IsoXmlTag("RvslTxRslt")]
    public required RetailerReversalResult5 ReversalTransactionResult { get; init; }

    /// <summary>
    /// Amount that have been reverse.
    /// </summary>
    [IsoId("_rsS__XHBEe2TbaNWBpRZpQ")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

    /// <summary>
    /// Various receipts linked to the reversal.
    /// </summary>
    [IsoId("_rsS__3HBEe2TbaNWBpRZpQ")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public PaymentReceipt5? Receipt { get; init; }
}
