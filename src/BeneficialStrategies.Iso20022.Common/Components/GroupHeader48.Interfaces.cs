// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader48 : IGroupHeader48
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader48.Authorisation => Authorisation;
    IPartyIdentification43 IGroupHeader48.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader48.ForwardingAgent => ForwardingAgent;
}
