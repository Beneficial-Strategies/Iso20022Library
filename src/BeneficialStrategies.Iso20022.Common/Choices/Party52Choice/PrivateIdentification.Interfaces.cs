// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Party52Choice;

public partial record PrivateIdentification : IPrivateIdentification
{
    IPersonIdentification18 IPrivateIdentification.Value => Value;
}
