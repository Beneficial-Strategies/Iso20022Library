// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies data element nexessary to request balance information.
/// </summary>
[IsoId("_PD2PQXG1Ee2TbaNWBpRZpQ")]
[DisplayName("Balance Inquiry Request")]
public record BalanceInquiryRequest6
{
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_PKkiUXG1Ee2TbaNWBpRZpQ")]
    [DisplayName("Sale Transaction Identification")]
    [IsoXmlTag("SaleTxId")]
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; }

    /// <summary>
    /// Data related to the account pointed by the payment card.
    /// </summary>
    [IsoId("_PKkiU3G1Ee2TbaNWBpRZpQ")]
    [DisplayName("Payment Account Request")]
    [IsoXmlTag("PmtAcctReq")]
    public PaymentAccountRequest1? PaymentAccountRequest { get; init; }

    /// <summary>
    /// Data related to a requested Loyalty program or account.
    /// </summary>
    [IsoId("_PKkiVXG1Ee2TbaNWBpRZpQ")]
    [DisplayName("Loyalty Account Request")]
    [IsoXmlTag("LltyAcctReq")]
    public LoyaltyAccountRequest3? LoyaltyAccountRequest { get; init; }

    /// <summary>
    /// Data related to a requested Stored value account.
    /// </summary>
    [IsoId("_PKkiV3G1Ee2TbaNWBpRZpQ")]
    [DisplayName("Stored Value Account Request")]
    [IsoXmlTag("StordValAcctReq")]
    public StoredValueRequest6? StoredValueAccountRequest { get; init; }
}
