// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.LocalInstrument1Choice;

/// <summary>
/// Specifies the local instrument as a proprietary code.
/// </summary>
[IsoId("_TGhDCdp-Ed-ak6NoX_4Aeg_-2017969230")]
public interface IProprietary : ILocalInstrument1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
