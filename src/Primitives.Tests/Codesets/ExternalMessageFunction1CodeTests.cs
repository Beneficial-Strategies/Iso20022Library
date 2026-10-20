// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalMessageFunction1CodeTests : ExternalCodesetContractTests<ExternalMessageFunction1Code>
{
    protected override string ValidSample => "ADVC";
    protected override string InvalidSample => "TOOLONG";
}
