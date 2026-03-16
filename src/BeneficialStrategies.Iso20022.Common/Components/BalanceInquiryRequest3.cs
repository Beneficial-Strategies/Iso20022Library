// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Balance Inquiry Request message.
/// </summary>
[IsoId("_qkw4UQxqEeqdx6buGpCCQw")]
[DisplayName("Balance Inquiry Request")]
public record BalanceInquiryRequest3
{
    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    [IsoId("_qxshEQxqEeqdx6buGpCCQw")]
    [DisplayName("Payment Account Request")]
    [IsoXmlTag("PmtAcctReq")]
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; }

    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    [IsoId("_qxshEwxqEeqdx6buGpCCQw")]
    [DisplayName("Loyalty Account Request")]
    [IsoXmlTag("LltyAcctReq")]
    public LoyaltyAccountRequest2? LoyaltyAccountRequest { get; init; }

    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    [IsoId("_qxshFQxqEeqdx6buGpCCQw")]
    [DisplayName("Stored Value Account Request")]
    [IsoXmlTag("StordValAcctReq")]
    public StoredValueRequest3? StoredValueAccountRequest { get; init; }
}
