// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.StatusReason6Choice;

/// <summary>
/// Reason for the status, in a proprietary form.
/// </summary>
[IsoId("_TRGiaNp-Ed-ak6NoX_4Aeg_-1877638936")]
public interface IProprietary : IStatusReason6Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    Max35Text Value { get; }
}
