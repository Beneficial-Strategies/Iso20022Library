// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AmountOrRate1Choice;

/// <summary>
/// Amount expressed as a rate.
/// </summary>
[IsoId("_Q-Unctp-Ed-ak6NoX_4Aeg_827689641")]
public interface IRate : IAmountOrRate1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
    /// </summary>
    [IsoXmlTag("Rate")]
    IsoPercentageRate Value { get; }
}
