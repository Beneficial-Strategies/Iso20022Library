// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalChequeCancellationStatus1CodeTests : ExternalCodesetContractTests<ExternalChequeCancellationStatus1Code>
{
    protected override string ValidSample => "ACCR";
    protected override string InvalidSample => "TOOLONG";
}
