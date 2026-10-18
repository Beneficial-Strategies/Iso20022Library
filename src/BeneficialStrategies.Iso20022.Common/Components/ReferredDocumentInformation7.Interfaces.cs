// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ReferredDocumentInformation7 : IReferredDocumentInformation7
{
    IReferredDocumentType4? IReferredDocumentInformation7.Type => Type;
    IEnumerable<IDocumentLineInformation1> IReferredDocumentInformation7.LineDetails => LineDetails;
}
