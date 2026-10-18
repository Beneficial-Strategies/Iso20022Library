// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInstruction15 : ISettlementInstruction15
{
    ICashAccount40? ISettlementInstruction15.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification3Choice? ISettlementInstruction15.ClearingSystem => ClearingSystem;
    IBranchAndFinancialInstitutionIdentification8? ISettlementInstruction15.InstructingReimbursementAgent => InstructingReimbursementAgent;
    ICashAccount40? ISettlementInstruction15.InstructingReimbursementAgentAccount => InstructingReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification8? ISettlementInstruction15.InstructedReimbursementAgent => InstructedReimbursementAgent;
    ICashAccount40? ISettlementInstruction15.InstructedReimbursementAgentAccount => InstructedReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification8? ISettlementInstruction15.ThirdReimbursementAgent => ThirdReimbursementAgent;
    ICashAccount40? ISettlementInstruction15.ThirdReimbursementAgentAccount => ThirdReimbursementAgentAccount;
}
