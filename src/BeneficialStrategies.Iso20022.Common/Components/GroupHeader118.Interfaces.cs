// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader118 : IGroupHeader118
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader118.Authorisation => Authorisation;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader118.ForwardingAgent => ForwardingAgent;
    IPartyIdentification272 IGroupHeader118.InitiatingParty => InitiatingParty;
}
