// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record SettlementInformation13 : ISettlementInformation13
{
    ICashAccount16? ISettlementInformation13.SettlementAccount => SettlementAccount;
    IClearingSystemIdentification3Choice? ISettlementInformation13.ClearingSystem => ClearingSystem;
    IBranchAndFinancialInstitutionIdentification4? ISettlementInformation13.InstructingReimbursementAgent => InstructingReimbursementAgent;
    ICashAccount16? ISettlementInformation13.InstructingReimbursementAgentAccount => InstructingReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification4? ISettlementInformation13.InstructedReimbursementAgent => InstructedReimbursementAgent;
    ICashAccount16? ISettlementInformation13.InstructedReimbursementAgentAccount => InstructedReimbursementAgentAccount;
    IBranchAndFinancialInstitutionIdentification4? ISettlementInformation13.ThirdReimbursementAgent => ThirdReimbursementAgent;
    ICashAccount16? ISettlementInformation13.ThirdReimbursementAgentAccount => ThirdReimbursementAgentAccount;
}
