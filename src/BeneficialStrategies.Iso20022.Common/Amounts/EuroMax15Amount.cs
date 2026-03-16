// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// Number of monetary units specified in a currency, where the unit of currency is the EUR and compliant with ISO 4217. The decimal separator is a dot, of maximum 15 digits before the dot and 2 after.|Note: A zero amount is not allowed.
/// </summary>
public record EuroMax15Amount
{
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_VwiZQNp-Ed-ak6NoX_4Aeg_-197866358_Currency")]
    [DisplayName("Euro Max 15 Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required System.String Currency { get; init; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_VwiZQNp-Ed-ak6NoX_4Aeg_-197866358_Amount")]
    [DisplayName("Euro Max 15 Amount _ Amount")]
    [IsoXmlTag("Amount")]
    public required System.Decimal Amount { get; init; }
}
