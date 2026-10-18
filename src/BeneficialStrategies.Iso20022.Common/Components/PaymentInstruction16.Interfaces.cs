// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction16 : IPaymentInstruction16
{
    IPaymentTypeInformation19? IPaymentInstruction16.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction16.Debtor => Debtor;
    ICashAccount24 IPaymentInstruction16.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction16.DebtorAgent => DebtorAgent;
    ICashAccount24? IPaymentInstruction16.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43? IPaymentInstruction16.UltimateDebtor => UltimateDebtor;
    ICashAccount24? IPaymentInstruction16.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification5? IPaymentInstruction16.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction20> IPaymentInstruction16.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
