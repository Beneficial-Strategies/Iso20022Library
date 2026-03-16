// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response Data to a Reversal request.
/// </summary>
[IsoId("_EOnRMQ04EeqUVL7sB4m7NA")]
[DisplayName("Reversal Response")]
public record ReversalResponse3
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_EboZgQ04EeqUVL7sB4m7NA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_EboZgw04EeqUVL7sB4m7NA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_EboZhQ04EeqUVL7sB4m7NA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_EboZhw04EeqUVL7sB4m7NA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_EboZiQ04EeqUVL7sB4m7NA")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Result of reversal transaction.
    /// </summary>
    [IsoId("_EboZiw04EeqUVL7sB4m7NA")]
    [DisplayName("Reversal Transaction Result")]
    [IsoXmlTag("RvslTxRslt")]
    public required RetailerReversalResult2 ReversalTransactionResult { get; init; }

    /// <summary>
    /// Amount that have been reverse.
    /// </summary>
    [IsoId("_EboZjQ04EeqUVL7sB4m7NA")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

    /// <summary>
    /// Various receipts linked to the reversal.
    /// </summary>
    [IsoId("_EboZjw04EeqUVL7sB4m7NA")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt2> Receipt { get; init; } = [];
}
