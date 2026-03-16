// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// A number of monetary units specified in an active or a historic currency where the unit of currency is explicit and compliant with ISO 4217.
/// </summary>
public record ActiveOrHistoricCurrencyAnd20DecimalAmount
{
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_uJAHQMz2EeufhKfUxzsnrQ_Currency")]
    [DisplayName("Active Or Historic Currency And 20 Decimal Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required System.String Currency { get; init; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_uJAHQMz2EeufhKfUxzsnrQ_Amount")]
    [DisplayName("Active Or Historic Currency And 20 Decimal Amount _ Amount")]
    [IsoXmlTag("Amount")]
    public required System.Decimal Amount { get; init; }
}
