// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record RemittanceInformation11 : IRemittanceInformation11
{
    IEnumerable<IsoMax140Text> IRemittanceInformation11.Unstructured => Unstructured;
    IEnumerable<IStructuredRemittanceInformation13> IRemittanceInformation11.Structured => Structured;
}
