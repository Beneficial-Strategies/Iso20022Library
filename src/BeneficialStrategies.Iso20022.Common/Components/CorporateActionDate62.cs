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
[IsoId("_dhQEP7QXEeeKRKrD60ELBQ")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate62
{
    /// <summary>
    /// Date/time on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_dwups7QXEeeKRKrD60ELBQ")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat43Choice_ PaymentDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_dwupu7QXEeeKRKrD60ELBQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateFormat46Choice_? ValueDate { get; init; }

    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_dwupw7QXEeeKRKrD60ELBQ")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateFormat43Choice_? ForeignExchangeRateFixingDate { get; init; }

    /// <summary>
    /// Date/time on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_dwupy7QXEeeKRKrD60ELBQ")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat43Choice_? EarliestPaymentDate { get; init; }
}
