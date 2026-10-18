// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.AdviceType1Choice;

/// <summary>
/// Advice type, in a coded form.
/// </summary>
[IsoId("_u3TXxNomEembTrt_WixjyQ")]
public interface ICode : IAdviceType1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the type of advice to provide back in the report.
    /// </summary>
    [IsoXmlTag("Cd")]
    AdviceType1Code Value { get; }
}
