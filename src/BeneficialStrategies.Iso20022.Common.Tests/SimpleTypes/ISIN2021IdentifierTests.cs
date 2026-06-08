// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ISIN2021IdentifierTests : SimpleValueStringContractTests<ISIN2021Identifier>
{
    protected override string ValidSample => "US0378331005";
    protected override string InvalidSample => "123456789012";
}
