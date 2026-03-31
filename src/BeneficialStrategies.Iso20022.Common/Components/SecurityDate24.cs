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
[IsoId("_YXgWfV99Ee262vCSVgjImg")]
[DisplayName("Security Date")]
public record SecurityDate24
{
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_YXgWgV99Ee262vCSVgjImg")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat41Choice_ PaymentDate { get; init; }

    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    [IsoId("_YXgWiV99Ee262vCSVgjImg")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateFormat41Choice_? AvailableDate { get; init; }

    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_YXgWkV99Ee262vCSVgjImg")]
    [DisplayName("Dividend Ranking Date")]
    [IsoXmlTag("DvddRnkgDt")]
    public DateFormat41Choice_? DividendRankingDate { get; init; }

    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_YXgWmV99Ee262vCSVgjImg")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat41Choice_? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_YXgWoV99Ee262vCSVgjImg")]
    [DisplayName("Pari Passu Date")]
    [IsoXmlTag("PrpssDt")]
    public DateFormat41Choice_? PariPassuDate { get; init; }

    /// <summary>
    /// Date/time at which the securities to be reorganised will cease to be tradeable.
    /// </summary>
    [IsoId("_YXgWqV99Ee262vCSVgjImg")]
    [DisplayName("Last Trading Date")]
    [IsoXmlTag("LastTradgDt")]
    public DateFormat41Choice_? LastTradingDate { get; init; }
}
