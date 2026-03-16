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
[IsoId("_7OgBINxCEeioifFt1dhnJA")]
[DisplayName("Payment Response")]
public record PaymentResponse1
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_F05YENxDEeioifFt1dhnJA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public required TransactionIdentifier1 SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Global reference of the sale transaction for the sale system.
    /// </summary>
    [IsoId("_gJ5GYezMEeiojesOXOKoug")]
    [DisplayName("Sale Reference Identification")]
    [IsoXmlTag("SaleRefId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SaleReferenceIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_JPaXINxDEeioifFt1dhnJA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; }

    /// <summary>
    /// Unique identification of the reconciliation period between the acceptor and the acquirer.
    /// </summary>
    [IsoId("_OOZZoNxDEeioifFt1dhnJA")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction given by the Issuer.
    /// </summary>
    [IsoId("_MSzBQe2qEei-V5h0ja04AA")]
    [DisplayName("Issuer Reference Data")]
    [IsoXmlTag("IssrRefData")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IssuerReferenceData { get; init; }

    /// <summary>
    /// Data related to the result of a processed payment transaction.
    /// </summary>
    [IsoId("_lugjENxFEeioifFt1dhnJA")]
    [DisplayName("Retailer Payment Result")]
    [IsoXmlTag("RtlrPmtRslt")]
    public required RetailerPaymentResult1 RetailerPaymentResult { get; init; }

    /// <summary>
    /// Customer or Merchant payment receipt.
    /// </summary>
    [IsoId("_9N76kNxIEeioifFt1dhnJA")]
    [DisplayName("Payment Receipt")]
    [IsoXmlTag("PmtRct")]
    public PaymentReceipt1? PaymentReceipt { get; init; }

    /// <summary>
    /// Data related to the result of a processed loyalty transaction.
    /// </summary>
    [IsoId("_MhX9gNxLEeioifFt1dhnJA")]
    [DisplayName("Loyalty Result")]
    [IsoXmlTag("LltyRslt")]
    public LoyaltyResult1? LoyaltyResult { get; init; }

    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_Pv1dkNxLEeioifFt1dhnJA")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; }
}
