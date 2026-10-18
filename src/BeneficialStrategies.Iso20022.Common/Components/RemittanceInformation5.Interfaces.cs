// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation5 : IRemittanceInformation5
{
    IEnumerable<IsoMax140Text> IRemittanceInformation5.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation7> IRemittanceInformation5.Structured => Structured;
}
