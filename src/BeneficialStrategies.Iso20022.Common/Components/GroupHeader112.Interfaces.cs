// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader112 : IGroupHeader112
{
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader112.ForwardingAgent => ForwardingAgent;
    IPartyIdentification272 IGroupHeader112.InitiatingParty => InitiatingParty;
}
