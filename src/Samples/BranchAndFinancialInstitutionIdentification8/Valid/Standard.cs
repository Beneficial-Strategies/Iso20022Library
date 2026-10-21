// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Samples.BranchAndFinancialInstitutionIdentification8.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>BranchAndFinancialInstitutionIdentification8</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>BranchAndFinancialInstitutionIdentification8</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static IBranchAndFinancialInstitutionIdentification8 Minimal =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                    .Set(x2 => x2.FinancialInstitutionIdentification).To(Samples.FinancialInstitutionIdentification23.Valid.Standard.Minimal));

    /// <summary>A valid <c>Standard</c> of <c>BranchAndFinancialInstitutionIdentification8</c> with more members set than Minimal. A new object on every access.</summary>
    public static IBranchAndFinancialInstitutionIdentification8 Maximal =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                    .Set(x2 => x2.FinancialInstitutionIdentification).To(Samples.FinancialInstitutionIdentification23.Valid.Standard.Minimal)
                    .Set(x2 => x2.BranchIdentification).To(Samples.BranchData5.Valid.Standard.Minimal));
}
