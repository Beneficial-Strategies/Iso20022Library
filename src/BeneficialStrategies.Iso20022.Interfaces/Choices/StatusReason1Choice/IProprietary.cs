// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.StatusReason1Choice;

/// <summary>
/// Reason for the status not catered for by the available codes.
/// </summary>
[IsoId("_TPKBoNp-Ed-ak6NoX_4Aeg_-1029924144")]
public interface IProprietary : IStatusReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
