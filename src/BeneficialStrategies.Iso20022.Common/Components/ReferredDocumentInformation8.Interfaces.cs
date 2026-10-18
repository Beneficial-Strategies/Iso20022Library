// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record ReferredDocumentInformation8 : IReferredDocumentInformation8
{
    IEnumerable<IDocumentLineInformation2> IReferredDocumentInformation8.LineDetails => LineDetails;
    IDateAndType1? IReferredDocumentInformation8.RelatedDate => RelatedDate;
    IDocumentType1? IReferredDocumentInformation8.Type => Type;
}
