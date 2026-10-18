// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader1 : IGroupHeader1
{
    IEnumerable<string> IGroupHeader1.Authorisation => Authorisation;
    IPartyIdentification8 IGroupHeader1.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification3? IGroupHeader1.ForwardingAgent => ForwardingAgent;
}
