// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader83 : IGroupHeader83
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader83.Authorisation => Authorisation;
    IPartyIdentification135 IGroupHeader83.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader83.ForwardingAgent => ForwardingAgent;
}
