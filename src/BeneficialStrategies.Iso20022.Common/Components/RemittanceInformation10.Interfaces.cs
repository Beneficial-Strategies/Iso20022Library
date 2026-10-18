// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation10 : IRemittanceInformation10
{
    IEnumerable<IsoMax140Text> IRemittanceInformation10.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation12> IRemittanceInformation10.Structured => Structured;
}
