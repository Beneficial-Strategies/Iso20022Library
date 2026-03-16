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
[IsoId("_qpF07zQKEe2o-K1dwNg8Gg")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate87
{
    /// <summary>
    /// Date/time of the posting (credit or debit) to the account.
    /// </summary>
    [IsoId("_rA7s0TQKEe2o-K1dwNg8Gg")]
    [DisplayName("Posting Date")]
    [IsoXmlTag("PstngDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate PostingDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_rA7s2TQKEe2o-K1dwNg8Gg")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ValueDate { get; init; }

    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_rA7s4TQKEe2o-K1dwNg8Gg")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateAndDateTime2Choice_? ForeignExchangeRateFixingDate { get; init; }

    /// <summary>
    /// Date/time on which a payment can be made, for example, if the payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_rA7s6TQKEe2o-K1dwNg8Gg")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EarliestPaymentDate { get; init; }

    /// <summary>
    /// Date on which the distribution is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_rA7s8TQKEe2o-K1dwNg8Gg")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PaymentDate { get; init; }
}
