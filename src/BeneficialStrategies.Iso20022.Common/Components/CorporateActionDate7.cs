// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action dates.
/// </summary>
[IsoId("_Ta7z2tp-Ed-ak6NoX_4Aeg_1877231589")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate7
{
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_Ta7z29p-Ed-ak6NoX_4Aeg_-1779583180")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTimeChoice_ PostingDate { get; init; }

    /// <summary>
    /// Date/time at which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [IsoId("_TbE9wNp-Ed-ak6NoX_4Aeg_1877231620")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTimeChoice_? ValueDate { get; init; }

    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_TbE9wdp-Ed-ak6NoX_4Aeg_1877231651")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateAndDateTimeChoice_? ForeignExchangeRateFixingDate { get; init; }

    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_TbE9wtp-Ed-ak6NoX_4Aeg_-1762960657")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateAndDateTimeChoice_? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Date on which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TbE9w9p-Ed-ak6NoX_4Aeg_-1703853356")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateAndDateTimeChoice_? PaymentDate { get; init; }
}
