// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class EICIdentifierTests : SimpleValueStringContractTests<EICIdentifier>
{
    protected override string ValidSample   => "10YFR-RTE------E";
    protected override string InvalidSample => "TOOSHORT";
}
