// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ReferredMandateDocument1 : IReferredMandateDocument1
{
    IReferredDocumentType4? IReferredMandateDocument1.Type => Type;
}
