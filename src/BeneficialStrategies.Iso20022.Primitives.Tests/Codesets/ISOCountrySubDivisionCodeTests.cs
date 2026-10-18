// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISOCountrySubDivisionCodeTests : ExternalCodesetContractTests<ISOCountrySubDivisionCode>
{
    protected override string ValidSample => "CA";
    protected override string InvalidSample => "C";
}
