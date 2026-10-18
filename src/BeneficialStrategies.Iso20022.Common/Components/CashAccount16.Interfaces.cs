// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CashAccount16 : ICashAccount16
{
    IAccountIdentification4Choice ICashAccount16.Identification => Identification;
    ICashAccountType2? ICashAccount16.Type => Type;
}
