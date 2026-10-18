// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader95 : IGroupHeader95
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader95.Authorisation => Authorisation;
    IPartyIdentification135 IGroupHeader95.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader95.ForwardingAgent => ForwardingAgent;
    IPaymentInitiationSource1? IGroupHeader95.InitiationSource => InitiationSource;
}
