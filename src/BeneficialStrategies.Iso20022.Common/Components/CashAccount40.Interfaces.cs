// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record CashAccount40 : ICashAccount40
{
    IAccountIdentification4Choice? ICashAccount40.Identification => Identification;
    ICashAccountType2Choice? ICashAccount40.Type => Type;
    IProxyAccountIdentification1? ICashAccount40.Proxy => Proxy;
}
