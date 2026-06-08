// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class SHA256SignatureTextTests : SimpleValueStringContractTests<SHA256SignatureText>
{
    protected override string ValidSample => "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
    protected override string InvalidSample => "TOOSHORT";
}
