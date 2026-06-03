// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to respond to a payment request.
/// </summary>
[IsoId("_0L804bYMEfCUZfsQO4rYeA")]
[DisplayName("Payment Response8")]
public record PaymentResponse8
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_0M6eNbYMEfCUZfsQO4rYeA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_0M6eO7YMEfCUZfsQO4rYeA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_0M6eQbYMEfCUZfsQO4rYeA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_0M6eR7YMEfCUZfsQO4rYeA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_0M6eTbYMEfCUZfsQO4rYeA")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_0M6eU7YMEfCUZfsQO4rYeA")]
    [DisplayName("Retailer Payment Result")]
    [IsoXmlTag("RtlrPmtRslt")]
    public required RetailerPaymentResult8 RetailerPaymentResult { get; init; }

    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_0M6eWbYMEfCUZfsQO4rYeA")]
    [DisplayName("Payment Receipt")]
    [IsoXmlTag("PmtRct")]
    public ValueList<PaymentReceipt7> PaymentReceipt { get; init; } = [];

    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// </summary>
    [IsoId("_0M6eX7YMEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Result")]
    [IsoXmlTag("LltyRslt")]
    public ValueList<LoyaltyResult3> LoyaltyResult { get; init; } = [];

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_0M6eZbYMEfCUZfsQO4rYeA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];
}
