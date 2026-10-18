// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader105 : IGroupHeader105
{
    IPartyIdentification135 IGroupHeader105.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader105.ForwardingAgent => ForwardingAgent;
}
