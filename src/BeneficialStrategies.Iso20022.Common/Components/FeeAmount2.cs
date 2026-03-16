// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount, currency, exchange rate and quotation date, sign and label.
/// </summary>
[IsoId("_zRsDMFKPEeeFcfYfFkVztg")]
[DisplayName("Fee Amount")]
public record FeeAmount2
{
    /// <summary>
    /// Amount exclusive of currency.
    /// ISO 8583:87 bit 8, 28, 29, 30 &amp; 31
    /// ISO 8583:93/2003 bit 8 &amp; 46
    /// </summary>
    [IsoId("_zeCdIVKPEeeFcfYfFkVztg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency for the type of amount.
    /// </summary>
    [IsoId("_zeCdI1KPEeeFcfYfFkVztg")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Exchange rate of the currency code associated with the amount.
    /// ISO 8583 bit 9 (for use with reconciliation/settlement amount)
    /// ISO 8583 bit 10 (for use with cardholder billing amount)
    /// </summary>
    [IsoId("_zeCdJVKPEeeFcfYfFkVztg")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; }

    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_zeCdJ1KPEeeFcfYfFkVztg")]
    [DisplayName("Quotation Date")]
    [IsoXmlTag("QtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? QuotationDate { get; init; }

    /// <summary>
    /// Indicates whether the amount value is positive or negative.
    /// Negative: the receiver of the message owes the fee to the sender.
    /// Positive: the sender of the message owes the fee to the receiver.
    /// </summary>
    [IsoId("_9lf1UVKPEeeFcfYfFkVztg")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }
}
