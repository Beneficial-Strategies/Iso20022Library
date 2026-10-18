// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction8 : IPaymentInstruction8
{
    IPaymentTypeInformation19? IPaymentInstruction8.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction8.Debtor => Debtor;
    ICashAccount24? IPaymentInstruction8.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction8.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IPaymentInstruction8.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransaction5> IPaymentInstruction8.CreditTransferTransaction => CreditTransferTransaction;
}
