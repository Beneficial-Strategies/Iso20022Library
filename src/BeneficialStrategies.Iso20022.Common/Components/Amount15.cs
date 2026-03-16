// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount, currency, exchange rate and quotation date.
/// </summary>
[IsoId("_WfYR0ZFyEeukDPgU2BMkjQ")]
[DisplayName("Amount")]
public record Amount15
{
    /// <summary>
    /// Amount exclusive of currency.
    /// </summary>
    [IsoId("_Wmb8EZFyEeukDPgU2BMkjQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency code associated with the applicable type of amount.  ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
    /// </summary>
    [IsoId("_Wmb8E5FyEeukDPgU2BMkjQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// The factor used in the conversion from one amount to another amount.
    /// </summary>
    [IsoId("_Wmb8FZFyEeukDPgU2BMkjQ")]
    [DisplayName("Effective Exchange Rate")]
    [IsoXmlTag("FctvXchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOne25Rate)]
    public IsoBaseOne25Rate? EffectiveExchangeRate { get; init; }

    /// <summary>
    /// Date at which the exchange rate effective.
    /// </summary>
    [IsoId("_Wmb8F5FyEeukDPgU2BMkjQ")]
    [DisplayName("Conversion Date")]
    [IsoXmlTag("ConvsDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ConversionDate { get; init; }

    /// <summary>
    /// Time at which the exchange rate effective.
    /// </summary>
    [IsoId("_v4dZ8JFyEeukDPgU2BMkjQ")]
    [DisplayName("Conversion Time")]
    [IsoXmlTag("ConvsTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? ConversionTime { get; init; }
}
