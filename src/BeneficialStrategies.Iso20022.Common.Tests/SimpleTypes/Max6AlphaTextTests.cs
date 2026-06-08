// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class Max6AlphaTextTests : SimpleValueStringContractTests<Max6AlphaText>
{
    protected override string ValidSample   => "ABCDEF";
    protected override string InvalidSample => "123456";
}
