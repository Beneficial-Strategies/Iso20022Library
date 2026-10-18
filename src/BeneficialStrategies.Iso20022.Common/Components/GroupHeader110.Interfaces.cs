// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader110 : IGroupHeader110
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader110.Authorisation => Authorisation;
    IPartyIdentification272? IGroupHeader110.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader110.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader110.InstructingAgent => InstructingAgent;
}
