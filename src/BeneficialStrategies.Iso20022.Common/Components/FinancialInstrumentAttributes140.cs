// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes of the financial instrument.
/// </summary>
[IsoId("_m-bPIGFTEfC91ZUW7iS7ww")]
[DisplayName("Financial Instrument Attributes140")]
public record FinancialInstrumentAttributes140
{
    /// <summary>
    /// Code used to identify the financial instrument.
    /// </summary>
    [IsoId("_xVaREGFTEfC91ZUW7iS7ww")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public required IsoISINOct2015Identifier ISIN { get; init; }

    /// <summary>
    /// Major currency in which the instrument trades.
    /// </summary>
    [IsoId("_9ohBcGFTEfC91ZUW7iS7ww")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }
}
