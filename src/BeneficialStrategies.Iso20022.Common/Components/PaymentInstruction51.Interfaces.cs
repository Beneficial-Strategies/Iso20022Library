// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction51 : IPaymentInstruction51
{
    IAdviceType1? IPaymentInstruction51.RequestedAdviceType => RequestedAdviceType;
    IPaymentTypeInformation26? IPaymentInstruction51.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice IPaymentInstruction51.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification272 IPaymentInstruction51.Debtor => Debtor;
    ICashAccount40 IPaymentInstruction51.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 IPaymentInstruction51.DebtorAgent => DebtorAgent;
    ICashAccount40? IPaymentInstruction51.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification272? IPaymentInstruction51.UltimateDebtor => UltimateDebtor;
    ICashAccount40? IPaymentInstruction51.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification8? IPaymentInstruction51.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction76> IPaymentInstruction51.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
