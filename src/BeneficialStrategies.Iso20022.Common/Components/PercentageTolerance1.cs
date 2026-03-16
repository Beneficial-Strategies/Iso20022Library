// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Variance allowed on a quantity or on a price.
/// </summary>
[IsoId("_SsvRF9p-Ed-ak6NoX_4Aeg_964334524")]
[DisplayName("Percentage Tolerance")]
public record PercentageTolerance1
{
    /// <summary>
    /// Variance in percentage allowed over the agreed dimension. For example, plus 10 percent.
    /// </summary>
    [IsoId("_SsvRGNp-Ed-ak6NoX_4Aeg_981883394")]
    [DisplayName("Plus Percent")]
    [IsoXmlTag("PlusPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate PlusPercent { get; init; }

    /// <summary>
    /// Variance in percentage allowed below the agreed dimension. For example, minus 10 percent.
    /// </summary>
    [IsoId("_SsvRGdp-Ed-ak6NoX_4Aeg_1021595225")]
    [DisplayName("Minus Percent")]
    [IsoXmlTag("MnsPct")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate MinusPercent { get; init; }
}
