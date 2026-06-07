// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalIndustrySectorClassification1CodeTests : ExternalCodesetContractTests<ExternalIndustrySectorClassification1Code>
{
    protected override string ValidSample => "AGRI";
    protected override string InvalidSample => "TOOLONG";
}
