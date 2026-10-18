// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction6 : IPaymentInstruction6
{
    IPaymentTypeInformation19? IPaymentInstruction6.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction6.Debtor => Debtor;
    ICashAccount24 IPaymentInstruction6.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction6.DebtorAgent => DebtorAgent;
    ICashAccount24? IPaymentInstruction6.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43? IPaymentInstruction6.UltimateDebtor => UltimateDebtor;
    ICashAccount24? IPaymentInstruction6.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification5? IPaymentInstruction6.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction1> IPaymentInstruction6.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
