// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the invoice amount and the terms of the foreign exchange transaction.
/// </summary>
[IsoId("_xIt20Uw0EfCpsI1b9uv5FQ")]
[DisplayName("Amount And Foreign Exchange1")]
public record AmountAndForeignExchange1
{
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    [IsoId("_xLDZIUw0EfCpsI1b9uv5FQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_xLDZI0w0EfCpsI1b9uv5FQ")]
    [DisplayName("Foreign Exchange")]
    [IsoXmlTag("FX")]
    public ForeignExchangeTerms24? ForeignExchange { get; init; }
}
