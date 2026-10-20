// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.Factory;
using BeneficialStrategies.Iso20022.SimpleTypes;

namespace BeneficialStrategies.Iso20022.Samples.BranchAndFinancialInstitutionIdentification8.Valid;

/// <summary>Valid samples of <c>Standard</c> of <c>BranchAndFinancialInstitutionIdentification8</c>.</summary>
public static class Standard
{
    /// <summary>A valid <c>Standard</c> of <c>BranchAndFinancialInstitutionIdentification8</c> with few members set (what the validator tests needed). A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Components.IBranchAndFinancialInstitutionIdentification8 Minimal =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                    .Set(x2 => x2.FinancialInstitutionIdentification).To(BeneficialStrategies.Iso20022.Samples.FinancialInstitutionIdentification23.Valid.Standard.Minimal));

    /// <summary>A valid <c>Standard</c> of <c>BranchAndFinancialInstitutionIdentification8</c> with more members set than Minimal. A new object on every access.</summary>
    public static BeneficialStrategies.Iso20022.Components.IBranchAndFinancialInstitutionIdentification8 Maximal =>
        IsoDataFactory.Make<IBranchAndFinancialInstitutionIdentification8>(b2 => b2
                    .Set(x2 => x2.FinancialInstitutionIdentification).To(BeneficialStrategies.Iso20022.Samples.FinancialInstitutionIdentification23.Valid.Standard.Minimal)
                    .Set(x2 => x2.BranchIdentification).To(BeneficialStrategies.Iso20022.Samples.BranchData5.Valid.Standard.Minimal));
}
