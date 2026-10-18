// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation15 : IRemittanceInformation15
{
    IEnumerable<Max140Text> IRemittanceInformation15.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation15> IRemittanceInformation15.Structured => Structured;
}
