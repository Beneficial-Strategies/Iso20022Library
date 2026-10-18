// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CashAccount38 : ICashAccount38
{
    IAccountIdentification4Choice ICashAccount38.Identification => Identification;
    ICashAccountType2Choice? ICashAccount38.Type => Type;
    IProxyAccountIdentification1? ICashAccount38.Proxy => Proxy;
}
