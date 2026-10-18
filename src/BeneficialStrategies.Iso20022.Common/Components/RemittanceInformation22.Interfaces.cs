// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation22 : IRemittanceInformation22
{
    IEnumerable<IStructuredRemittanceInformation18> IRemittanceInformation22.Structured => Structured;
    IEnumerable<IsoMax140Text> IRemittanceInformation22.Unstructured => Unstructured;
}
