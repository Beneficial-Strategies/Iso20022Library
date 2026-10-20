// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class XsdNMTOKENSTests : SimpleValueStringContractTests<XsdNMTOKENS>
{
    protected override string ValidSample => "1st-token 2nd-token";
    protected override string InvalidSample => "has#invalid-char";
}
