// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader123 : IGroupHeader123
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader123.Authorisation => Authorisation;
    ISettlementInstruction15 IGroupHeader123.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation28? IGroupHeader123.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader123.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification8? IGroupHeader123.InstructedAgent => InstructedAgent;
}
