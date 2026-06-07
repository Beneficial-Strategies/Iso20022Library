// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalBankTransactionFamilyCodeTests : ExternalCodesetContractTests<ExternalBankTransactionFamilyCode>
{
    protected override string ValidSample => "CCRD";
    protected override string InvalidSample => "TOOLONG";
}
