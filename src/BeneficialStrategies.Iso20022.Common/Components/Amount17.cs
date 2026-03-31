// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Signed amount in a given currency
/// </summary>
[IsoId("_9J43AZMjEeuleeHpFMMhmQ")]
[DisplayName("Amount")]
public record Amount17
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_9UzGgZMjEeuleeHpFMMhmQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Currency code associated with the applicable type of amount.  ISO 4217 &quot;Codes for the representation of currencies and funds&quot;.
    /// </summary>
    [IsoId("_9UzGg5MjEeuleeHpFMMhmQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ISO3NumericCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Sign of the Amount.
    /// </summary>
    [IsoId("_9UzGhZMjEeuleeHpFMMhmQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }
}
