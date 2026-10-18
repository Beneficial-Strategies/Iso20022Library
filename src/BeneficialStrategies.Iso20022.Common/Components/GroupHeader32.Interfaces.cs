// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader32 : IGroupHeader32
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader32.Authorisation => Authorisation;
    IPartyIdentification32 IGroupHeader32.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader32.ForwardingAgent => ForwardingAgent;
}
