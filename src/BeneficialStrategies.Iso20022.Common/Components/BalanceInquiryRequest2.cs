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
[IsoId("_YW_NMYYLEemxIqbaFEE8-w")]
[DisplayName("Balance Inquiry Request")]
public record BalanceInquiryRequest2
{
    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    [IsoId("_YhOuUYYLEemxIqbaFEE8-w")]
    [DisplayName("Payment Account Request")]
    [IsoXmlTag("PmtAcctReq")]
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; }

    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    [IsoId("_YhOuU4YLEemxIqbaFEE8-w")]
    [DisplayName("Loyalty Account Request")]
    [IsoXmlTag("LltyAcctReq")]
    public LoyaltyAccountRequest1? LoyaltyAccountRequest { get; init; }

    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    [IsoId("_YhOuVYYLEemxIqbaFEE8-w")]
    [DisplayName("Stored Value Account Request")]
    [IsoXmlTag("StordValAcctReq")]
    public StoredValueRequest2? StoredValueAccountRequest { get; init; }
}
