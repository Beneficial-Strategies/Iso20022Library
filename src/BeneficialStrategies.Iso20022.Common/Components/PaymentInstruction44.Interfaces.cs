// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction44 : IPaymentInstruction44
{
    ICashAccount40? IPaymentInstruction44.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification8? IPaymentInstruction44.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction61> IPaymentInstruction44.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
    IPartyIdentification272 IPaymentInstruction44.Debtor => Debtor;
    ICashAccount40 IPaymentInstruction44.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 IPaymentInstruction44.DebtorAgent => DebtorAgent;
    ICashAccount40? IPaymentInstruction44.DebtorAgentAccount => DebtorAgentAccount;
    IPaymentTypeInformation26? IPaymentInstruction44.PaymentTypeInformation => PaymentTypeInformation;
    IAdviceType1? IPaymentInstruction44.RequestedAdviceType => RequestedAdviceType;
    IDateAndDateTime2Choice IPaymentInstruction44.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification272? IPaymentInstruction44.UltimateDebtor => UltimateDebtor;
}
