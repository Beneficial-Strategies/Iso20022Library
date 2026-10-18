// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader114 : IGroupHeader114
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader114.Authorisation => Authorisation;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader114.ForwardingAgent => ForwardingAgent;
    IPartyIdentification272 IGroupHeader114.InitiatingParty => InitiatingParty;
    IPaymentInitiationSource1? IGroupHeader114.InitiationSource => InitiationSource;
}
