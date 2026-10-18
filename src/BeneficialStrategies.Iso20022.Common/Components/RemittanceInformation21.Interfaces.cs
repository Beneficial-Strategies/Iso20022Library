// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation21 : IRemittanceInformation21
{
    IEnumerable<IsoMax140Text> IRemittanceInformation21.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation17> IRemittanceInformation21.Structured => Structured;
}
