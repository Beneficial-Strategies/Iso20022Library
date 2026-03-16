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
[IsoId("_XTY-ofo9EeCdeaSQAR2tKw")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate24
{
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_XTY-o_o9EeCdeaSQAR2tKw")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    public required DateAndDateTimeChoice_ PostingDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_XTY-rfo9EeCdeaSQAR2tKw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateAndDateTimeChoice_? ValueDate { get; init; }

    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_XTY-t_o9EeCdeaSQAR2tKw")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateAndDateTimeChoice_? ForeignExchangeRateFixingDate { get; init; }

    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_XTY-wfo9EeCdeaSQAR2tKw")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateAndDateTimeChoice_? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Date on which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_XTY-y_o9EeCdeaSQAR2tKw")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public DateAndDateTimeChoice_? PaymentDate { get; init; }
}
