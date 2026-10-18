// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader55 : IGroupHeader55
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader55.Authorisation => Authorisation;
    IPartyIdentification43 IGroupHeader55.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader55.ForwardingAgent => ForwardingAgent;
}
