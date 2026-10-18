// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DocumentLineInformation1 : IDocumentLineInformation1
{
    IEnumerable<IDocumentLineIdentification1> IDocumentLineInformation1.Identification => Identification;
    IRemittanceAmount3? IDocumentLineInformation1.Amount => Amount;
}
