// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation6 : IRemittanceInformation6
{
    IEnumerable<IsoMax140Text> IRemittanceInformation6.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation8> IRemittanceInformation6.Structured => Structured;
}
