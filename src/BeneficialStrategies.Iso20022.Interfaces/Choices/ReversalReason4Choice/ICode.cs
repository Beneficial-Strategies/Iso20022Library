// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReversalReason4Choice;

/// <summary>
/// Reason for the reversal, as published in an external reason code list.
/// </summary>
[IsoId("_TRGiYNp-Ed-ak6NoX_4Aeg_-340627868")]
public interface ICode : IReversalReason4Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the reversal reason, as published in an external reversal reason code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalReversalReason1Code Value { get; }
}
