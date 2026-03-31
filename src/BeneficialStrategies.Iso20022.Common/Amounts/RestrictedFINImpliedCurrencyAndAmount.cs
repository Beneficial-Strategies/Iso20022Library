// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Amounts;

/// <summary>
/// Number of monetary units specified in a currency where the unit of currency is implied by the context and compliant with ISO 4217. The decimal separator is a dot.|Note: a zero amount is considered a positive amount.
/// </summary>
public record RestrictedFINImpliedCurrencyAndAmount
{
    /// <summary>
    /// The currency in which this amount is measured.
    /// </summary>
    [IsoId("_XZJV1Np-Ed-ak6NoX_4Aeg_681057429_Currency")]
    [DisplayName("Restricted FIN Implied Currency And Amount _ Currency")]
    [IsoXmlTag("Currency")]
    public required System.String Currency { get; init; }

    /// <summary>
    /// Amount of the transaction.
    /// </summary>
    [IsoId("_XZJV1Np-Ed-ak6NoX_4Aeg_681057429_Amount")]
    [DisplayName("Restricted FIN Implied Currency And Amount _ Amount")]
    [IsoXmlTag("Amount")]
    public required System.Decimal Amount { get; init; }
}
