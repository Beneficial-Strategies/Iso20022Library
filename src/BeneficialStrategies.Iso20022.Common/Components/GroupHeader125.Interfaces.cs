// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader125 : IGroupHeader125
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader125.Authorisation => Authorisation;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader125.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader125.InstructingAgent => InstructingAgent;
    IPaymentTypeInformation27? IGroupHeader125.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementInstruction14 IGroupHeader125.SettlementInformation => SettlementInformation;
}
