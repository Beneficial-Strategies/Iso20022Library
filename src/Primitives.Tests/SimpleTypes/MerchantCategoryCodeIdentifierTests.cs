// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.SimpleTypes;

public class MerchantCategoryCodeIdentifierTests : SimpleValueStringContractTests<MerchantCategoryCodeIdentifier>
{
    protected override string ValidSample => "5411";
    protected override string InvalidSample => "541X";
}
