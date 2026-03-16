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
[IsoId("_LbjN8fo9EeCdeaSQAR2tKw")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate23
{
    /// <summary>
    /// Date on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_LbjN9_o9EeCdeaSQAR2tKw")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat19Choice_ PaymentDate { get; init; }

    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_LbjOAfo9EeCdeaSQAR2tKw")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateFormat11Choice_? ValueDate { get; init; }

    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_LbjOC_o9EeCdeaSQAR2tKw")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateFormat19Choice_? ForeignExchangeRateFixingDate { get; init; }

    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_LbjOFfo9EeCdeaSQAR2tKw")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat19Choice_? EarliestPaymentDate { get; init; }
}
