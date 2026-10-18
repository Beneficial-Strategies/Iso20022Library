// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ProxyAccountIdentification1 : IProxyAccountIdentification1
{
    IProxyAccountType1Choice? IProxyAccountIdentification1.Type => Type;
}
