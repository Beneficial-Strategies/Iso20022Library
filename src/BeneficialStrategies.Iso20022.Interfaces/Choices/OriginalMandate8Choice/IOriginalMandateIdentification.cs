// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate8Choice;

/// <summary>
/// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the original mandate.
/// </summary>
[IsoId("_bQuQEdcZEeqRFcf2R4bPBw")]
public interface IOriginalMandateIdentification : IOriginalMandate8Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("OrgnlMndtId")]
    IsoMax35Text Value { get; }
}
