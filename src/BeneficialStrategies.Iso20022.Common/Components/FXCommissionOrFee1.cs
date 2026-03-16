// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the foreign exchange commissions and fees amounts.
/// </summary>
[IsoId("_Tv5YAANyEe2-vqzwMUAewg")]
[DisplayName("FX Commission Or Fee")]
public record FXCommissionOrFee1
{
    /// <summary>
    /// Type of the commission or fee.
    /// </summary>
    [IsoId("_e4y_EANyEe2-vqzwMUAewg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required FXAmountType1Choice_ Type { get; init; }

    /// <summary>
    /// Amount or rate of the commissions and fees.
    /// </summary>
    [IsoId("_oLLJYANyEe2-vqzwMUAewg")]
    [DisplayName("Amount Or Rate")]
    [IsoXmlTag("AmtOrRate")]
    public required AmountOrRate4Choice_ AmountOrRate { get; init; }

    /// <summary>
    /// Indicates that the amount or rate value is positive or negative.
    /// Usage: when absent, it means that amount value is 0 or positive.
    /// </summary>
    [IsoId("_pC8e4ANyEe2-vqzwMUAewg")]
    [DisplayName("Sign")]
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    public IsoPlusOrMinusIndicator? Sign { get; init; }
}
