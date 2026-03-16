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
[IsoId("_dCdOg7QXEeeKRKrD60ELBQ")]
[DisplayName("Security Date")]
public record SecurityDate15
{
    /// <summary>
    /// Date of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_dSOv07QXEeeKRKrD60ELBQ")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTime2Choice_ PostingDate { get; init; }

    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    [IsoId("_dSOv27QXEeeKRKrD60ELBQ")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateFormat43Choice_? AvailableDate { get; init; }

    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_dSOv47QXEeeKRKrD60ELBQ")]
    [DisplayName("Pari Passu Date")]
    [IsoXmlTag("PrpssDt")]
    public DateFormat43Choice_? PariPassuDate { get; init; }

    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_dSOv67QXEeeKRKrD60ELBQ")]
    [DisplayName("Dividend Ranking Date")]
    [IsoXmlTag("DvddRnkgDt")]
    public DateFormat43Choice_? DividendRankingDate { get; init; }

    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_dSOv87QXEeeKRKrD60ELBQ")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat43Choice_? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_dSOv-7QXEeeKRKrD60ELBQ")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateFormat43Choice_? PaymentDate { get; init; }
}
