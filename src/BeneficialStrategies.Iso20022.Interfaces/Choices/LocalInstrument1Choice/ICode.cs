// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.LocalInstrument1Choice;

/// <summary>
/// Specifies the local instrument published in an external local instrument code list.
/// </summary>
[IsoId("_TGhDCNp-Ed-ak6NoX_4Aeg_-2017969272")]
public interface ICode : ILocalInstrument1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the external local instrument code in the format of character string with a maximum length of 35 characters.|The list of valid codes is an external code list published separately.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalLocalInstrumentCode_Obsolete Value { get; }
}
