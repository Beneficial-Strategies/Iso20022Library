// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader96 : IGroupHeader96
{
    ISettlementInstruction11 IGroupHeader96.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation28? IGroupHeader96.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader96.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification6? IGroupHeader96.InstructedAgent => InstructedAgent;
}
