// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class DateOffsetTextTests : SimpleValueStringContractTests<DateOffsetText>
{
    protected override string ValidSample => "0";
    protected override string InvalidSample => "5";
}
