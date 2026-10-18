// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation1 : IRemittanceInformation1
{
    IEnumerable<IsoMax140Text> IRemittanceInformation1.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation6> IRemittanceInformation1.Structured => Structured;
}
