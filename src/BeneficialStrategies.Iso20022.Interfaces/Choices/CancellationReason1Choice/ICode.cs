// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason1Choice;

/// <summary>
/// Reason for the cancellation request in a coded form.
/// </summary>
[IsoId("_TO3GtNp-Ed-ak6NoX_4Aeg_-748049469")]
public interface ICode : ICancellationReason1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the reason for requesting the cancellation of a payment instruction.
    /// </summary>
    [IsoXmlTag("Cd")]
    CancellationReason2Code Value { get; }
}
