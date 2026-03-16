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
[IsoId("_skDv8U0tEeybj420QgWBkA")]
[DisplayName("Payment Response")]
public record PaymentResponse4
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_sra8MU0tEeybj420QgWBkA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_sra8M00tEeybj420QgWBkA")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_sra8NU0tEeybj420QgWBkA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_sra8N00tEeybj420QgWBkA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_sra8OU0tEeybj420QgWBkA")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_sra8O00tEeybj420QgWBkA")]
    [DisplayName("Retailer Payment Result")]
    [IsoXmlTag("RtlrPmtRslt")]
    public required RetailerPaymentResult4 RetailerPaymentResult { get; init; }

    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_sra8PU0tEeybj420QgWBkA")]
    [DisplayName("Payment Receipt")]
    [IsoXmlTag("PmtRct")]
    public PaymentReceipt4? PaymentReceipt { get; init; }

    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// </summary>
    [IsoId("_sra8P00tEeybj420QgWBkA")]
    [DisplayName("Loyalty Result")]
    [IsoXmlTag("LltyRslt")]
    public LoyaltyResult3? LoyaltyResult { get; init; }

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_sra8QU0tEeybj420QgWBkA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }
}
