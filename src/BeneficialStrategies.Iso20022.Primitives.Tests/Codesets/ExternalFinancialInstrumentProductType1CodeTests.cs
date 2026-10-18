// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Codesets;

namespace BeneficialStrategies.Iso20022.Codesets;

public class ExternalFinancialInstrumentProductType1CodeTests : ExternalCodesetContractTests<ExternalFinancialInstrumentProductType1Code>
{
    protected override string ValidSample => "EQUI";
    protected override string InvalidSample => "TOOLONG";
}
