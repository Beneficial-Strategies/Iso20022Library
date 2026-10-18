// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader51 : IGroupHeader51
{
    ISettlementInstruction1 IGroupHeader51.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation21? IGroupHeader51.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader51.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification5? IGroupHeader51.InstructedAgent => InstructedAgent;
}
