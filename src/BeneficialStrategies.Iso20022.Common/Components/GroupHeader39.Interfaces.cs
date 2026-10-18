// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader39 : IGroupHeader39
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader39.Authorisation => Authorisation;
    IPartyIdentification32 IGroupHeader39.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader39.ForwardingAgent => ForwardingAgent;
}
