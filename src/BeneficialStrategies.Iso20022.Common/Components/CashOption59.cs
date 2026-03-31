// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
[IsoId("_bSvSYbQZEeeKRKrD60ELBQ")]
[DisplayName("Cash Option")]
public record CashOption59
{
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_bhnb4bQZEeeKRKrD60ELBQ")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_bhnb6bQZEeeKRKrD60ELBQ")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account8Choice_? Account { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_bhnb8bQZEeeKRKrD60ELBQ")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTime2Choice_ PostingDate { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    [IsoId("_bhnb-bQZEeeKRKrD60ELBQ")]
    [DisplayName("Original Posting Date")]
    [IsoXmlTag("OrgnlPstngDt")]
    public DateAndDateTime2Choice_? OriginalPostingDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_bhnb-7QZEeeKRKrD60ELBQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTime2Choice_? ValueDate { get; init; }

    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_bhncA7QZEeeKRKrD60ELBQ")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required ActiveCurrencyAndAmount PostingAmount { get; init; }
}
