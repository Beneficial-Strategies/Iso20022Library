// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data to respond to a Payment request.
/// </summary>
[IsoId("_9qLT0Q03EeqUVL7sB4m7NA")]
[DisplayName("Payment Response")]
public record PaymentResponse2
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_924TEQ03EeqUVL7sB4m7NA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_924TEw03EeqUVL7sB4m7NA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_924TFQ03EeqUVL7sB4m7NA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_924TFw03EeqUVL7sB4m7NA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_924TGQ03EeqUVL7sB4m7NA")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_924TGw03EeqUVL7sB4m7NA")]
    [DisplayName("Retailer Payment Result")]
    [IsoXmlTag("RtlrPmtRslt")]
    public required RetailerPaymentResult2 RetailerPaymentResult { get; init; }

    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_924THQ03EeqUVL7sB4m7NA")]
    [DisplayName("Payment Receipt")]
    [IsoXmlTag("PmtRct")]
    public ValueList<PaymentReceipt2> PaymentReceipt { get; init; } = [];

    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// </summary>
    [IsoId("_924THw03EeqUVL7sB4m7NA")]
    [DisplayName("Loyalty Result")]
    [IsoXmlTag("LltyRslt")]
    public ValueList<LoyaltyResult2> LoyaltyResult { get; init; } = [];

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_924TIQ03EeqUVL7sB4m7NA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public ValueList<CustomerOrder1> CustomerOrder { get; init; } = [];
}
