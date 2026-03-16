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
[IsoId("_gsrpcfo9EeCdeaSQAR2tKw")]
[DisplayName("Cash Option")]
public record CashOption19
{
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    [IsoId("_gsrpd_o9EeCdeaSQAR2tKw")]
    [DisplayName("Credit Debit Indicator")]
    [IsoXmlTag("CdtDbtInd")]
    public required CreditDebitCode CreditDebitIndicator { get; init; }

    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [IsoId("_gsrpgfo9EeCdeaSQAR2tKw")]
    [DisplayName("Account")]
    [IsoXmlTag("Acct")]
    public Account8Choice_? Account { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_gsrpi_o9EeCdeaSQAR2tKw")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTimeChoice_ PostingDate { get; init; }

    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    [IsoId("_gsrplfo9EeCdeaSQAR2tKw")]
    [DisplayName("Original Posting Date")]
    [IsoXmlTag("OrgnlPstngDt")]
    public DateAndDateTimeChoice_? OriginalPostingDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_gsrpmfo9EeCdeaSQAR2tKw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTimeChoice_? ValueDate { get; init; }

    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    [IsoId("_gsrpo_o9EeCdeaSQAR2tKw")]
    [DisplayName("Posting Amount")]
    [IsoXmlTag("PstngAmt")]
    public required ActiveCurrencyAndAmount PostingAmount { get; init; }
}
