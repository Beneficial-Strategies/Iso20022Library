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
[IsoId("_TcbBl9p-Ed-ak6NoX_4Aeg_-1492537729")]
[DisplayName("Corporate Action Date")]
public record CorporateActionDate9
{
    /// <summary>
    /// Date on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_TcbBmNp-Ed-ak6NoX_4Aeg_-1492537634")]
    [DisplayName("Payment Date")]
    [IsoXmlTag("PmtDt")]
    public required DateFormat6Choice_ PaymentDate { get; init; }

    /// <summary>
    /// Date at which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [IsoId("_TcbBmdp-Ed-ak6NoX_4Aeg_-1492537694")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public DateFormat11Choice_? ValueDate { get; init; }

    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_TcbBmtp-Ed-ak6NoX_4Aeg_-1492537669")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    [IsoXmlTag("FXRateFxgDt")]
    public DateFormat6Choice_? ForeignExchangeRateFixingDate { get; init; }

    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_TckykNp-Ed-ak6NoX_4Aeg_-1492537652")]
    [DisplayName("Earliest Payment Date")]
    [IsoXmlTag("EarlstPmtDt")]
    public DateFormat6Choice_? EarliestPaymentDate { get; init; }
}
