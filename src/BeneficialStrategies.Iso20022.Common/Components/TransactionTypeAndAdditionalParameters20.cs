// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
[IsoId("_yYMhXZw2EeazcsnODTksnQ")]
[DisplayName("Transaction Type And Additional Parameters")]
public record TransactionTypeAndAdditionalParameters20
{
    /// <summary>
    /// Unambiguous identification of the transaction (unique per piece of collateral) as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_yYMhX5w2EeazcsnODTksnQ")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction (unique per piece of collateral) as known by the account servicer.
    /// </summary>
    [IsoId("_yYMhZ5w2EeazcsnODTksnQ")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    [IsoId("_yYMhb5w2EeazcsnODTksnQ")]
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_yYMhd5w2EeazcsnODTksnQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Identifies the type of securities financing modification requested.
    /// </summary>
    [IsoId("_yYMhf5w2EeazcsnODTksnQ")]
    [DisplayName("Modification Type")]
    [IsoXmlTag("ModTp")]
    public RepurchaseType31Choice_? ModificationType { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_yYMhh5w2EeazcsnODTksnQ")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? CommonIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_yYMhj5w2EeazcsnODTksnQ")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? PoolIdentification { get; init; }
}
