// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.FinancialIdentificationSchemeName1Choice;

/// <summary>
/// Name of the identification scheme, in a coded form as published in an external list.
/// </summary>
[IsoId("_QALkMdp-Ed-ak6NoX_4Aeg_-2021925430")]
public interface ICode : IFinancialIdentificationSchemeName1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the external financial institution identification scheme name code in the format of character string with a maximum length of 4 characters.
    /// The list of valid codes is an external code list published separately.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalFinancialInstitutionIdentification1Code Value { get; }
}
