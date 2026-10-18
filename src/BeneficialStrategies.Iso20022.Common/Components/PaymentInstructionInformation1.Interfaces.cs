// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstructionInformation1 : IPaymentInstructionInformation1
{
    IPaymentTypeInformation1? IPaymentInstructionInformation1.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification8 IPaymentInstructionInformation1.Debtor => Debtor;
    ICashAccount7 IPaymentInstructionInformation1.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification3 IPaymentInstructionInformation1.DebtorAgent => DebtorAgent;
    ICashAccount7? IPaymentInstructionInformation1.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification8? IPaymentInstructionInformation1.UltimateDebtor => UltimateDebtor;
    ICashAccount7? IPaymentInstructionInformation1.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification3? IPaymentInstructionInformation1.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransactionInformation1> IPaymentInstructionInformation1.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
