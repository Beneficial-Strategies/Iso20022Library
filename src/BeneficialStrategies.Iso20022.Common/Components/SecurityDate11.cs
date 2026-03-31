// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security date details.
/// </summary>
[IsoId("_LECKt0EEEeWVgfuHGaKtRQ")]
[DisplayName("Security Date")]
public record SecurityDate11
{
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_LQFpU0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTimeChoice_ PostingDate { get; init; }

    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    [IsoId("_LQFpW0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateFormat31Choice_? AvailableDate { get; init; }

    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_LQFpY0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Pari Passu Date")]
    [IsoXmlTag("PrpssDt")]
    public DateFormat31Choice_? PariPassuDate { get; init; }

    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_LQFpa0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Dividend Ranking Date")]
    [IsoXmlTag("DvddRnkgDt")]
    public DateFormat31Choice_? DividendRankingDate { get; init; }

    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_LQFpc0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat31Choice_? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_LQFpe0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat31Choice_? PaymentDate { get; init; }
}
