// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction30 : IPaymentInstruction30
{
    IPaymentTypeInformation26? IPaymentInstruction30.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTime2Choice IPaymentInstruction30.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification135 IPaymentInstruction30.Debtor => Debtor;
    ICashAccount38 IPaymentInstruction30.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification6 IPaymentInstruction30.DebtorAgent => DebtorAgent;
    ICashAccount38? IPaymentInstruction30.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification135? IPaymentInstruction30.UltimateDebtor => UltimateDebtor;
    ICashAccount38? IPaymentInstruction30.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification6? IPaymentInstruction30.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction34> IPaymentInstruction30.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
