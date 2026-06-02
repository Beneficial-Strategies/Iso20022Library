// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies data elements necessary to request balance information.
/// </summary>
[IsoId("_Ft1swbZZEfCUZfsQO4rYeA")]
[DisplayName("Balance Inquiry Request9")]
public record BalanceInquiryRequest9
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_Fuw51bZZEfCUZfsQO4rYeA")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    [IsoId("_Fuw527ZZEfCUZfsQO4rYeA")]
    [DisplayName("Payment Account Request")]
    [IsoXmlTag("PmtAcctReq")]
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; }

    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    [IsoId("_Fuw54bZZEfCUZfsQO4rYeA")]
    [DisplayName("Loyalty Account Request")]
    [IsoXmlTag("LltyAcctReq")]
    public LoyaltyAccountRequest3? LoyaltyAccountRequest { get; init; }

    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    [IsoId("_Fuw557ZZEfCUZfsQO4rYeA")]
    [DisplayName("Stored Value Account Request")]
    [IsoXmlTag("StordValAcctReq")]
    public StoredValueRequest9? StoredValueAccountRequest { get; init; }
}
