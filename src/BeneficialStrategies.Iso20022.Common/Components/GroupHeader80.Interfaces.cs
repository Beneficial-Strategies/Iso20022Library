// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader80 : IGroupHeader80
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader80.Authorisation => Authorisation;
    IPartyIdentification135? IGroupHeader80.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader80.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader80.InstructedAgent => InstructedAgent;
}
