// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction35 : IPaymentInstruction35
{
    IAdviceType1? IPaymentInstruction35.RequestedAdviceType => RequestedAdviceType;
    IPaymentTypeInformation26? IPaymentInstruction35.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice IPaymentInstruction35.RequestedExecutionDate => RequestedExecutionDate;
    IDateAndDateTime2Choice? IPaymentInstruction35.ExpiryDate => ExpiryDate;
    IPaymentCondition1? IPaymentInstruction35.PaymentCondition => PaymentCondition;
    IPartyIdentification135 IPaymentInstruction35.Debtor => Debtor;
    ICashAccount38? IPaymentInstruction35.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction35.DebtorAgent => DebtorAgent;
    IPartyIdentification135? IPaymentInstruction35.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction42> IPaymentInstruction35.CreditTransferTransaction => CreditTransferTransaction;
}
