// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed amounts associated with the total amount of transaction.
/// </summary>
[IsoId("_yXuW0TAlEeOqioR9srQH1g")]
[DisplayName("Detailed Amount")]
public record DetailedAmount4
{
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_-bSSgDApEeOqioR9srQH1g")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Short description of the amount to display or print.
    /// </summary>
    [IsoId("_yoPfFTAlEeOqioR9srQH1g")]
    [DisplayName("Label")]
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Label { get; init; }
}
