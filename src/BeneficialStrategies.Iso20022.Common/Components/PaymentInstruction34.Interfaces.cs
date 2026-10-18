// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction34 : IPaymentInstruction34
{
    IAdviceType1? IPaymentInstruction34.RequestedAdviceType => RequestedAdviceType;
    IPaymentTypeInformation26? IPaymentInstruction34.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice IPaymentInstruction34.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification135 IPaymentInstruction34.Debtor => Debtor;
    ICashAccount38 IPaymentInstruction34.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction34.DebtorAgent => DebtorAgent;
    ICashAccount38? IPaymentInstruction34.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification135? IPaymentInstruction34.UltimateDebtor => UltimateDebtor;
    ICashAccount38? IPaymentInstruction34.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification6? IPaymentInstruction34.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction40> IPaymentInstruction34.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
