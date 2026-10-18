// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader31 : IGroupHeader31
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader31.Authorisation => Authorisation;
    IPartyIdentification32? IGroupHeader31.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader31.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader31.InstructedAgent => InstructedAgent;
}
