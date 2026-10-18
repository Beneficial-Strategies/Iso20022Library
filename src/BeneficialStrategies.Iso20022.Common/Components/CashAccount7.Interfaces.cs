// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CashAccount7 : ICashAccount7
{
    IAccountIdentification3Choice ICashAccount7.Identification => Identification;
    ICashAccountType2? ICashAccount7.Type => Type;
}
