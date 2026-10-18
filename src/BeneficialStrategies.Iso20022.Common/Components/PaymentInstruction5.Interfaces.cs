// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction5 : IPaymentInstruction5
{
    IPaymentTypeInformation19? IPaymentInstruction5.PaymentTypeInformation => PaymentTypeInformation;
    IPartyIdentification43 IPaymentInstruction5.Debtor => Debtor;
    ICashAccount7? IPaymentInstruction5.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction5.DebtorAgent => DebtorAgent;
    IPartyIdentification43? IPaymentInstruction5.UltimateDebtor => UltimateDebtor;
    IEnumerable<ICreditTransferTransactionInformation14> IPaymentInstruction5.CreditTransferTransaction => CreditTransferTransaction;
}
