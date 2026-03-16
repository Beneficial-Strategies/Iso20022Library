// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// A number of monetary units specified in an active or a historic currency where the unit of currency is explicit and compliant with ISO 4217. The number of fractional digits (or minor unit of currency) is not checked as per ISO 4217: It must be lesser than or equal to 13.|Note: The decimal separator is a dot.
/// </summary>
public record RestrictedFINActiveOrHistoricCurrencyAnd13DecimalAmount
{
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_WOMlp9p-Ed-ak6NoX_4Aeg_-1678737059_Currency")]
    [DisplayName("Restricted FIN Active Or Historic Currency And 13 Decimal Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required System.String Currency { get; init; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_WOMlp9p-Ed-ak6NoX_4Aeg_-1678737059_Amount")]
    [DisplayName("Restricted FIN Active Or Historic Currency And 13 Decimal Amount _ Amount")]
    [IsoXmlTag("Amount")]
    public required System.Decimal Amount { get; init; }
}
