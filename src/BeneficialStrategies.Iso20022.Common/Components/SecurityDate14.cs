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
[IsoId("_cthr_5KQEeWHWpTQn1FFVg")]
[DisplayName("Security Date")]
public record SecurityDate14
{
    /// <summary>
    /// Date/time at which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_cthsAZKQEeWHWpTQn1FFVg")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat34Choice_ PaymentDate { get; init; }

    /// <summary>
    /// Date/time at which securities become available for trading, for example first dealing date.
    /// </summary>
    [IsoId("_cthsCZKQEeWHWpTQn1FFVg")]
    [DisplayName("Available Date")]
    [IsoXmlTag("AvlblDt")]
    public DateFormat34Choice_? AvailableDate { get; init; }

    /// <summary>
    /// Date/time at which a security will be entitled to a dividend.
    /// </summary>
    [IsoId("_cthsEZKQEeWHWpTQn1FFVg")]
    [DisplayName("Dividend Ranking Date")]
    [IsoXmlTag("DvddRnkgDt")]
    public DateFormat34Choice_? DividendRankingDate { get; init; }

    /// <summary>
    /// Date/time at which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_cthsGZKQEeWHWpTQn1FFVg")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat34Choice_? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Date/time at which security will assimilate, become fungible, or have the same rights to dividends as the parent issue.
    /// </summary>
    [IsoId("_cthsIZKQEeWHWpTQn1FFVg")]
    [DisplayName("Pari Passu Date")]
    [IsoXmlTag("PrpssDt")]
    public DateFormat34Choice_? PariPassuDate { get; init; }

    /// <summary>
    /// Date/time at which the securities to be reorganised will cease to be tradeable.
    /// </summary>
    [IsoId("_cthsKZKQEeWHWpTQn1FFVg")]
    [DisplayName("Last Trading Date")]
    [IsoXmlTag("LastTradgDt")]
    public DateFormat34Choice_? LastTradingDate { get; init; }
}
