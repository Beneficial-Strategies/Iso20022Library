// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record Document15 : IDocument15
{
    IPartyAndSignature4? IDocument15.DigitalSignature => DigitalSignature;
    IDocumentFormat1Choice IDocument15.Format => Format;
    IDateAndDateTime2Choice IDocument15.IssueDate => IssueDate;
    IDocumentType1Choice IDocument15.Type => Type;
}
