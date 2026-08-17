// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Codesets;

public class ISOMax3ALanguageCodeTests : ExternalCodesetContractTests<ISOMax3ALanguageCode>
{
    protected override string ValidSample => "eng";
    protected override string InvalidSample => "e";
}
