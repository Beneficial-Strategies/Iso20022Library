// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader70 : IGroupHeader70
{
    ISettlementInstruction4 IGroupHeader70.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation21? IGroupHeader70.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader70.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader70.InstructedAgent => InstructedAgent;
}
