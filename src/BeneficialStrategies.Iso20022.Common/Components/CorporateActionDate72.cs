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
[IsoId("_k9vXZc3xEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate72
{
    /// <summary>
    /// Date/time on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_k9vXac3xEee5nJBZsW8MFQ")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat49Choice_ PaymentDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_k9vXcc3xEee5nJBZsW8MFQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateFormat55Choice_? ValueDate { get; init; }

    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_k9vXec3xEee5nJBZsW8MFQ")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateFormat49Choice_? ForeignExchangeRateFixingDate { get; init; }

    /// <summary>
    /// Date/time on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_k9vXgc3xEee5nJBZsW8MFQ")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat49Choice_? EarliestPaymentDate { get; init; }
}
