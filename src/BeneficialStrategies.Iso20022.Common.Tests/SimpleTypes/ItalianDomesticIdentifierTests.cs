// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class ItalianDomesticIdentifierTests : SimpleValueStringContractTests<ItalianDomesticIdentifier>
{
    protected override string ValidSample   => "IT1234567890";
    protected override string InvalidSample => "XX1234567890";
}
