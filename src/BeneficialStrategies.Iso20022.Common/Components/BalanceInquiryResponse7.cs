// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the balance inquiry response message.
/// </summary>
[IsoId("_Xn_EgbZhEfCUZfsQO4rYeA")]
[DisplayName("Balance Inquiry Response7")]
public record BalanceInquiryResponse7
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_Xo5DdbZhEfCUZfsQO4rYeA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// POI identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_Xo5De7ZhEfCUZfsQO4rYeA")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public TransactionIdentifier1? POITransactionIdentification { get; init; }

    /// <summary>
    /// Payment account information.
    /// </summary>
    [IsoId("_Xo5DgbZhEfCUZfsQO4rYeA")]
    [DisplayName("Payment Account")]
    [IsoXmlTag("PmtAcct")]
    public PaymentAccount3? PaymentAccount { get; init; }

    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_Xo5Dh7ZhEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount3? LoyaltyAccount { get; init; }

    /// <summary>
    /// Stored value account information.
    /// </summary>
    [IsoId("_Xo5DjbZhEfCUZfsQO4rYeA")]
    [DisplayName("Stored Value Account")]
    [IsoXmlTag("StordValAcct")]
    public ValueList<StoredValueAccount2> StoredValueAccount { get; init; } = [];

    /// <summary>
    /// Receipt to print after a balance inquiry.
    /// </summary>
    [IsoId("_Xo5Dk7ZhEfCUZfsQO4rYeA")]
    [DisplayName("Receipt")]
    [IsoXmlTag("Rct")]
    public ValueList<PaymentReceipt7> Receipt { get; init; } = [];
}
