// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction41 : IPaymentInstruction41
{
    IAdviceType1? IPaymentInstruction41.RequestedAdviceType => RequestedAdviceType;
    IPaymentTypeInformation26? IPaymentInstruction41.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice IPaymentInstruction41.RequestedExecutionDate => RequestedExecutionDate;
    IDateAndDateTime2Choice? IPaymentInstruction41.ExpiryDate => ExpiryDate;
    IPaymentCondition1? IPaymentInstruction41.PaymentCondition => PaymentCondition;
    IPartyIdentification135 IPaymentInstruction41.Debtor => Debtor;
    ICashAccount40? IPaymentInstruction41.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction41.DebtorAgent => DebtorAgent;
    IPartyIdentification135? IPaymentInstruction41.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction55> IPaymentInstruction41.CreditTransferTransaction => CreditTransferTransaction;
}
