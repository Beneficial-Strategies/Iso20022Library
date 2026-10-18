// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ReferredMandateDocument2 : IReferredMandateDocument2
{
    IDateAndType1? IReferredMandateDocument2.RelatedDate => RelatedDate;
    IDocumentType1? IReferredMandateDocument2.Type => Type;
}
