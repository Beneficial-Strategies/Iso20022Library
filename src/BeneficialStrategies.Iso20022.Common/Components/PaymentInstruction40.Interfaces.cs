// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction40 : IPaymentInstruction40
{
    IAdviceType1? IPaymentInstruction40.RequestedAdviceType => RequestedAdviceType;
    IPaymentTypeInformation26? IPaymentInstruction40.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice IPaymentInstruction40.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification135 IPaymentInstruction40.Debtor => Debtor;
    ICashAccount40 IPaymentInstruction40.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction40.DebtorAgent => DebtorAgent;
    ICashAccount40? IPaymentInstruction40.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification135? IPaymentInstruction40.UltimateDebtor => UltimateDebtor;
    ICashAccount40? IPaymentInstruction40.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification6? IPaymentInstruction40.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction54> IPaymentInstruction40.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
