// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes each adjustment made to the original price.
/// </summary>
[IsoId("_wd8wXPNGEei4qfiLgRIZBA")]
[DisplayName("Adjustment")]
public record Adjustment11
{
    /// <summary>
    /// Contains the adjusted amount (for example, discounts).
    /// </summary>
    [IsoId("_wd8wZPNGEei4qfiLgRIZBA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ImpliedCurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Indicates whether or not the line item is a credit amount.
    /// </summary>
    [IsoId("_wd8wZfNGEei4qfiLgRIZBA")]
    [DisplayName("Credit Indicator")]
    [IsoXmlTag("CdtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CreditIndicator { get; init; }

    /// <summary>
    /// Reason for the adjustment.
    /// </summary>
    [IsoId("_wd8wYvNGEei4qfiLgRIZBA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; }
}
