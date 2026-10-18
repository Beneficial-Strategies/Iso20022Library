// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader113 : IGroupHeader113
{
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader113.InstructedAgent => InstructedAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader113.InstructingAgent => InstructingAgent;
    IPaymentTypeInformation28? IGroupHeader113.PaymentTypeInformation => PaymentTypeInformation;
    ISettlementInstruction15 IGroupHeader113.SettlementInformation => SettlementInformation;
}
