// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Min2Max3AlphaTextTests : SimpleValueStringContractTests<Min2Max3AlphaText>
{
    protected override string ValidSample   => "AB";
    protected override string InvalidSample => "1234";
}
