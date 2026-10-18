// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader33 : IGroupHeader33
{
    ISettlementInformation13 IGroupHeader33.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation21? IGroupHeader33.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader33.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader33.InstructedAgent => InstructedAgent;
}
