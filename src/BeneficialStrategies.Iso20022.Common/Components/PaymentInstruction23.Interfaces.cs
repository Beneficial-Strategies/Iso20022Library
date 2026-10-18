// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction23 : IPaymentInstruction23
{
    IPaymentTypeInformation19? IPaymentInstruction23.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTimeChoice IPaymentInstruction23.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification43 IPaymentInstruction23.Debtor => Debtor;
    ICashAccount24? IPaymentInstruction23.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction23.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IPaymentInstruction23.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction22> IPaymentInstruction23.CreditTransferTransaction => CreditTransferTransaction;
}
