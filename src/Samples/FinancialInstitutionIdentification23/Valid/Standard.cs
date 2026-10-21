// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.FinancialInstitutionIdentification23.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>FinancialInstitutionIdentification23</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>FinancialInstitutionIdentification23</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static IFinancialInstitutionIdentification23 Minimal =>
        IsoDataFactory.Make<IFinancialInstitutionIdentification23>();
}
