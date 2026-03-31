// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Securities financing transaction identification information, type (repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing) and other parameters.
/// </summary>
[IsoId("_y9mmj5w0EeazcsnODTksnQ")]
[DisplayName("Transaction Type And Additional Parameters")]
public record TransactionTypeAndAdditionalParameters18
{
    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    [IsoId("_y9mmkZw0EeazcsnODTksnQ")]
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_y9mmmZw0EeazcsnODTksnQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_y9mmoZw0EeazcsnODTksnQ")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? CommonIdentification { get; init; }

    /// <summary>
    /// Settlement transaction has already been sent on the market. It is sent by an account owner to an account servicer for reconciliation purposes.
    /// </summary>
    [IsoId("_y9mmqZw0EeazcsnODTksnQ")]
    [DisplayName("Reconciliation Indicator")]
    [IsoXmlTag("RcncltnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReconciliationIndicator { get; init; }
}
