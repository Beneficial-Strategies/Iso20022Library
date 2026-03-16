// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Balance Inquiry Response message.
/// </summary>
[IsoId("_lOzFkU7NEeyGi9JAv6wq7Q")]
[DisplayName("Balance Inquiry Response")]
public record BalanceInquiryResponse4
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_nPrxsU7tEeyGi9JAv6wq7Q")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_0Z4iIU7tEeyGi9JAv6wq7Q")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public TransactionIdentifier1? POITransactionIdentification { get; init; }

    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_lVC3gU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Payment Account")]
    [IsoXmlTag("PmtAcct")]
    public PaymentAccount3? PaymentAccount { get; init; }

    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_lVC3g07NEeyGi9JAv6wq7Q")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount3? LoyaltyAccount { get; init; }

    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_lVC3hU7NEeyGi9JAv6wq7Q")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public ValueList<StoredValueAccount2> StoredValueAccount { get; init; } = [];

    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_lVC3h07NEeyGi9JAv6wq7Q")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt4> Receipt { get; init; } = [];
}
