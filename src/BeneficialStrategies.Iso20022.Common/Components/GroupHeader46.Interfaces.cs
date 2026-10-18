// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader46 : IGroupHeader46
{
    IPartyIdentification43 IGroupHeader46.InitiatingParty => InitiatingParty;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader46.DebtorAgent => DebtorAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader46.CreditorAgent => CreditorAgent;
}
