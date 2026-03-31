// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed amount in a given numeric currency
/// </summary>
[IsoId("_X3LzYZJQEeuuktRxxQZoNQ")]
[DisplayName("Amount")]
public record Amount16
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_X9M70ZJQEeuuktRxxQZoNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_X9M705JQEeuuktRxxQZoNQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
