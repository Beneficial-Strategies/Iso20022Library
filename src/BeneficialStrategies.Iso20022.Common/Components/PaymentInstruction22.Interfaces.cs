// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentInstruction22 : IPaymentInstruction22
{
    IPaymentTypeInformation19? IPaymentInstruction22.PaymentTypeInformation => PaymentTypeInformation;
    IDateAndDateTimeChoice IPaymentInstruction22.RequestedExecutionDate => RequestedExecutionDate;
    IPartyIdentification43 IPaymentInstruction22.Debtor => Debtor;
    ICashAccount24 IPaymentInstruction22.DebtorAccount => DebtorAccount;
    IBranchAndFinancialInstitutionIdentification5 IPaymentInstruction22.DebtorAgent => DebtorAgent;
    ICashAccount24? IPaymentInstruction22.DebtorAgentAccount => DebtorAgentAccount;
    IPartyIdentification43? IPaymentInstruction22.UltimateDebtor => UltimateDebtor;
    ICashAccount24? IPaymentInstruction22.ChargesAccount => ChargesAccount;
    IBranchAndFinancialInstitutionIdentification5? IPaymentInstruction22.ChargesAccountAgent => ChargesAccountAgent;
    IEnumerable<ICreditTransferTransaction26> IPaymentInstruction22.CreditTransferTransactionInformation => CreditTransferTransactionInformation;
}
