// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Balance Inquiry Request8.
/// </summary>
[IsoId("_ipCGgaEUEe-MRKYsaX6JDg")]
[DisplayName("Balance Inquiry Request8")]
public record BalanceInquiryRequest8
{
    /// <summary>
    /// Loyalty Account Request.
    /// </summary>
    [DisplayName("Loyalty Account Request")]
    [IsoXmlTag("LltyAcctReq")]
    public LoyaltyAccountRequest3? LoyaltyAccountRequest { get; init; }

    /// <summary>
    /// Payment Account Request.
    /// </summary>
    [DisplayName("Payment Account Request")]
    [IsoXmlTag("PmtAcctReq")]
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; }

    /// <summary>
    /// Sale Transaction Identification.
    /// </summary>
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Stored Value Account Request.
    /// </summary>
    [DisplayName("Stored Value Account Request")]
    [IsoXmlTag("StordValAcctReq")]
    public StoredValueRequest8? StoredValueAccountRequest { get; init; }
}
