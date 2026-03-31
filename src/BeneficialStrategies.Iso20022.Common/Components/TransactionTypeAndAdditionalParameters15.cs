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
[IsoId("_IJOOAY7YEeaa5_S8lsRKCQ")]
[DisplayName("Transaction Type And Additional Parameters")]
public record TransactionTypeAndAdditionalParameters15
{
    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    [IsoId("_IXghoY7YEeaa5_S8lsRKCQ")]
    [DisplayName("Securities Financing Transaction Type")]
    [IsoXmlTag("SctiesFincgTxTp")]
    public required SecuritiesFinancingTransactionType2Code SecuritiesFinancingTransactionType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_IXghqY7YEeaa5_S8lsRKCQ")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_IXghsY7YEeaa5_S8lsRKCQ")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Settlement transaction has already been sent on the market. It is sent by an account owner to an account servicer for reconciliation purposes.
    /// </summary>
    [IsoId("_IXghuY7YEeaa5_S8lsRKCQ")]
    [DisplayName("Reconciliation Indicator")]
    [IsoXmlTag("RcncltnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ReconciliationIndicator { get; init; }
}
