// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record DocumentLineInformation2 : IDocumentLineInformation2
{
    IRemittanceAmount4? IDocumentLineInformation2.Amount => Amount;
    IEnumerable<IDocumentLineIdentification1> IDocumentLineInformation2.Identification => Identification;
}
