// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction9 : IPaymentInstruction9
{
    IPaymentTypeInformation19? IPaymentInstruction9.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction9.Debtor => Debtor;
    ICashAccount24 IPaymentInstruction9.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction9.DebtorAgent => DebtorAgent;
    ICashAccount24? IPaymentInstruction9.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43? IPaymentInstruction9.UltimateDebtor => UltimateDebtor;
    ICashAccount24? IPaymentInstruction9.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification5? IPaymentInstruction9.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction6> IPaymentInstruction9.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
