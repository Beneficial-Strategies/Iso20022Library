// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate1Choice;

/// <summary>
/// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
/// </summary>
[IsoId("_RD1ZlNp-Ed-ak6NoX_4Aeg_1242303052")]
public interface IOriginalMandateIdentification : IOriginalMandate1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies a character string with a maximum length of 35 characters.
    /// </summary>
    [IsoXmlTag("OrgnlMndtId")]
    IsoMax35Text Value { get; }
}
