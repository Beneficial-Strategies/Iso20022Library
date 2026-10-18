// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason1Choice;

/// <summary>
/// Reason for the cancellation request not catered for by the available codes.
/// </summary>
[IsoId("_TO3Gtdp-Ed-ak6NoX_4Aeg_-748049435")]
public interface IProprietary : ICancellationReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
