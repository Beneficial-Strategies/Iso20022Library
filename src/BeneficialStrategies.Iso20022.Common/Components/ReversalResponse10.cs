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
[IsoId("_YOl8sbYNEfCUZfsQO4rYeA")]
[DisplayName("Reversal Response10")]
public record ReversalResponse10
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_YPk0JbYNEfCUZfsQO4rYeA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_YPk0K7YNEfCUZfsQO4rYeA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_YPk0MbYNEfCUZfsQO4rYeA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_YPk0N7YNEfCUZfsQO4rYeA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_YPk0PbYNEfCUZfsQO4rYeA")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Result of reversal transaction.
    /// </summary>
    [IsoId("_YPk0Q7YNEfCUZfsQO4rYeA")]
    [DisplayName("Reversal Transaction Result")]
    [IsoXmlTag("RvslTxRslt")]
    public required RetailerReversalResult8 ReversalTransactionResult { get; init; }

    /// <summary>
    /// Amount that have been reverse.
    /// </summary>
    [IsoId("_YPk0SbYNEfCUZfsQO4rYeA")]
    [DisplayName("Reversed Amount")]
    [IsoXmlTag("RvsdAmt")]
    public ImpliedCurrencyAndAmount? ReversedAmount { get; init; }

    /// <summary>
    /// Various receipts linked to the reversal.
    /// </summary>
    [IsoId("_YPk0T7YNEfCUZfsQO4rYeA")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt7> Receipt { get; init; } = [];
}
