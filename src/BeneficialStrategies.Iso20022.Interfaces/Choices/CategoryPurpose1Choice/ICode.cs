// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Choices.CategoryPurpose1Choice;

/// <summary>
/// Category purpose, as published in an external category purpose code list.
/// </summary>
[IsoId("_THaa5dp-Ed-ak6NoX_4Aeg_1223014481")]
public interface ICode : ICategoryPurpose1Choice, IIsoChoiceVariant
{
    /// <summary>
    /// Contains the main value for the container.
    /// Specifies the category purpose, as published in an external category purpose code list.
    /// External code sets can be downloaded from www.iso20022.org.
    /// </summary>
    [IsoXmlTag("Cd")]
    ExternalCategoryPurpose1Code Value { get; }
}
