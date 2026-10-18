// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Document12 : IDocument12
{
    IDocumentType1Choice IDocument12.Type => Type;
    IDateAndDateTime2Choice IDocument12.IssueDate => IssueDate;
    IDocumentFormat1Choice IDocument12.Format => Format;
    IPartyAndSignature3? IDocument12.DigitalSignature => DigitalSignature;
}
