// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money due to the government or tax authority, according to various pre-defined parameters such as thresholds or income.
/// </summary>
[IsoId("_m4A6oTAXEeOKib24wnHaFg")]
[DisplayName("Tax")]
public record Tax22
{
    /// <summary>
    /// Specifies the type of tax.
    /// </summary>
    [IsoId("_nTxpkTAXEeOKib24wnHaFg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TaxType2Choice_ Type { get; init; }

    /// <summary>
    /// Specifies the tax as an amount.
    /// </summary>
    [IsoId("_uJ7pEDAXEeOKib24wnHaFg")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }
}
