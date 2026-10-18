// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.ReturnReason5Choice;

/// <summary>
/// Reason for the return, in a proprietary form.
/// </summary>
[IsoId("_TP6Pk9p-Ed-ak6NoX_4Aeg_-1676325975")]
public interface IProprietary : IReturnReason5Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("Prtry")]
    IsoMax35Text Value { get; }
}
