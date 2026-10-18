// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation16 : IRemittanceInformation16
{
    IEnumerable<Max140Text> IRemittanceInformation16.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation16> IRemittanceInformation16.Structured => Structured;
}
