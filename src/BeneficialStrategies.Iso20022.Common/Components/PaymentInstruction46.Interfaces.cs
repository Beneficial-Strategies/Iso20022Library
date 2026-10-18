// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction46 : IPaymentInstruction46
{
    IEnumerable<ICreditTransferTransaction65> IPaymentInstruction46.CreditTransferTransaction => CreditTransferTransaction;
    IPartyIdentification272 IPaymentInstruction46.Debtor => Debtor;
    ICashAccount40? IPaymentInstruction46.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification8 IPaymentInstruction46.DebtorAgent => DebtorAgent;
    ICashAccount40? IPaymentInstruction46.DebtorAgentAccount => DebtorAgentAccount;
    IDateAndDateTime2Choice? IPaymentInstruction46.ExpiryDate => ExpiryDate;
    IPaymentCondition2? IPaymentInstruction46.PaymentCondition => PaymentCondition;
    IPaymentTypeInformation29? IPaymentInstruction46.PaymentTypeInformation => PaymentTypeInformation;
    IAdviceType1? IPaymentInstruction46.RequestedAdviceType => RequestedAdviceType;
    IDateAndDateTime2Choice? IPaymentInstruction46.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification272? IPaymentInstruction46.UltimateDebtor => UltimateDebtor;
}
