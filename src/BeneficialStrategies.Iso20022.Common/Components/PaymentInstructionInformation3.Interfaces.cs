// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstructionInformation3 : IPaymentInstructionInformation3
{
    IPaymentTypeInformation19? IPaymentInstructionInformation3.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification32 IPaymentInstructionInformation3.Debtor => Debtor;
    ICashAccount16 IPaymentInstructionInformation3.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification4 IPaymentInstructionInformation3.DebtorAgent => DebtorAgent;
    ICashAccount16? IPaymentInstructionInformation3.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification32? IPaymentInstructionInformation3.UltimateDebtor => UltimateDebtor;
    ICashAccount16? IPaymentInstructionInformation3.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification4? IPaymentInstructionInformation3.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransactionInformation10> IPaymentInstructionInformation3.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
