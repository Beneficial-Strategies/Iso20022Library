// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader47 : IGroupHeader47
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader47.Authorisation => Authorisation;
    IPartyIdentification43? IGroupHeader47.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader47.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader47.InstructedAgent => InstructedAgent;
}
