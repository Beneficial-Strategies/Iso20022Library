// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInformation3 : ISettlementInformation3
{
    ICashAccount7? ISettlementInformation3.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification1Choice? ISettlementInformation3.ClearingSystem => ClearingSystem;
    IBranchAndFinancialInstitutionIdentification3? ISettlementInformation3.InstructingReimbursementAgent => InstructingReimbursementAgent;
    ICashAccount7? ISettlementInformation3.InstructingReimbursementAgentAccount => InstructingReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification3? ISettlementInformation3.InstructedReimbursementAgent => InstructedReimbursementAgent;
    ICashAccount7? ISettlementInformation3.InstructedReimbursementAgentAccount => InstructedReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification3? ISettlementInformation3.ThirdReimbursementAgent => ThirdReimbursementAgent;
    ICashAccount7? ISettlementInformation3.ThirdReimbursementAgentAccount => ThirdReimbursementAgentAccount;
}
