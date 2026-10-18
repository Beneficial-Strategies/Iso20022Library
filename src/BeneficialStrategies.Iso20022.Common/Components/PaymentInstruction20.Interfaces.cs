// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction20 : IPaymentInstruction20
{
    IPaymentTypeInformation19? IPaymentInstruction20.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction20.Debtor => Debtor;
    ICashAccount24 IPaymentInstruction20.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction20.DebtorAgent => DebtorAgent;
    ICashAccount24? IPaymentInstruction20.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43? IPaymentInstruction20.UltimateDebtor => UltimateDebtor;
    ICashAccount24? IPaymentInstruction20.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification5? IPaymentInstruction20.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction26> IPaymentInstruction20.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
