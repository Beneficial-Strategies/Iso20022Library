// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CashAccount24 : ICashAccount24
{
    IAccountIdentification4Choice ICashAccount24.Identification => Identification;
    ICashAccountType2Choice? ICashAccount24.Type => Type;
}
