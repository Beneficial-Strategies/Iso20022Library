// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader85 : IGroupHeader85
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader85.Authorisation => Authorisation;
    IPartyIdentification135 IGroupHeader85.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader85.ForwardingAgent => ForwardingAgent;
}
