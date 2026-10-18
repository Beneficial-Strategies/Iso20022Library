// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation7 : IRemittanceInformation7
{
    IEnumerable<Max140Text> IRemittanceInformation7.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation9> IRemittanceInformation7.Structured => Structured;
}
