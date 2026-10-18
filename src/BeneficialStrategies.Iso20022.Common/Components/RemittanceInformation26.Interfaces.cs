// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation26 : IRemittanceInformation26
{
    IEnumerable<Max140Text> IRemittanceInformation26.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation22> IRemittanceInformation26.Structured => Structured;
}
