// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record GroupHeader34 : IGroupHeader34
{
    IEnumerable<IAuthorisation1Choice> IGroupHeader34.Authorisation => Authorisation;
    ISettlementInformation14 IGroupHeader34.SettlementInformation => SettlementInformation;
    IPaymentTypeInformation22? IGroupHeader34.PaymentTypeInformation => PaymentTypeInformation;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader34.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification4? IGroupHeader34.InstructedAgent => InstructedAgent;
}
