// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statement information of an account.
/// </summary>
[IsoId("_lBqwQTaqEeyjpIf0r_Ojqw")]
[DisplayName("Account Statement Details")]
public record AccountStatementDetails2
{
    /// <summary>
    /// Date of the transaction.
    /// </summary>
    [IsoId("_lF5wATaqEeyjpIf0r_Ojqw")]
    [DisplayName("Transaction Date")]
    [IsoXmlTag("TxDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate TransactionDate { get; init; }

    /// <summary>
    /// True indicates transaction is pending.
    /// False indicates transaction has already posted.
    /// No default value.
    /// </summary>
    [IsoId("_lF5wAzaqEeyjpIf0r_Ojqw")]
    [DisplayName("Pending Indicator")]
    [IsoXmlTag("PdgInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? PendingIndicator { get; init; }

    /// <summary>
    /// Posting date of the transaction.
    /// </summary>
    [IsoId("_lF5wBTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Transaction Posting Date")]
    [IsoXmlTag("TxPstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TransactionPostingDate { get; init; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_lF6XETaqEeyjpIf0r_Ojqw")]
    [DisplayName("Transaction Amount")]
    [IsoXmlTag("TxAmt")]
    public Amount7? TransactionAmount { get; init; }

    /// <summary>
    /// Cardholder billing amount of the transaction.
    /// </summary>
    [IsoId("_lF6XEzaqEeyjpIf0r_Ojqw")]
    [DisplayName("Cardholder Billing Amount")]
    [IsoXmlTag("CrdhldrBllgAmt")]
    public Amount7? CardholderBillingAmount { get; init; }

    /// <summary>
    /// A code to indicate the tax amount is credit or debit
    /// </summary>
    [IsoId("_OBupwTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Currency of the amount.
    /// </summary>
    [IsoId("_lF6XFzaqEeyjpIf0r_Ojqw")]
    [DisplayName("Acceptor Name And Location")]
    [IsoXmlTag("AccptrNmAndLctn")]
    [IsoSimpleType(IsoSimpleType.Max99Text)]
    [StringLength(maximumLength: 99, MinimumLength = 1)]
    public IsoMax99Text? AcceptorNameAndLocation { get; init; }

    /// <summary>
    /// Short transaction description to print or display.
    /// </summary>
    [IsoId("_lF6XGTaqEeyjpIf0r_Ojqw")]
    [DisplayName("Short Transaction Description")]
    [IsoXmlTag("ShrtTxDesc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? ShortTransactionDescription { get; init; }

    /// <summary>
    /// Long transaction description to print or display.
    /// </summary>
    [IsoId("_lF6XGzaqEeyjpIf0r_Ojqw")]
    [DisplayName("Long Transaction Description")]
    [IsoXmlTag("LngTxDesc")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? LongTransactionDescription { get; init; }
}
