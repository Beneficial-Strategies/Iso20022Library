// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction42 : IPaymentInstruction42
{
    IAdviceType1? IPaymentInstruction42.RequestedAdviceType => RequestedAdviceType;
    IPaymentTypeInformation26? IPaymentInstruction42.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice? IPaymentInstruction42.RequestedExecutionDate => RequestedExecutionDate;
    IDateAndDateTime2Choice? IPaymentInstruction42.ExpiryDate => ExpiryDate;
    IPaymentCondition1? IPaymentInstruction42.PaymentCondition => PaymentCondition;
    IPartyIdentification135 IPaymentInstruction42.Debtor => Debtor;
    ICashAccount40? IPaymentInstruction42.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction42.DebtorAgent => DebtorAgent;
    ICashAccount40? IPaymentInstruction42.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification135? IPaymentInstruction42.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction57> IPaymentInstruction42.CreditTransferTransaction => CreditTransferTransaction;
}
