// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Components;

public partial record PaymentTransactionInformation5 : IPaymentTransactionInformation5
{
    IEnumerable<IChargesInformation1> IPaymentTransactionInformation5.ChargesInformation => ChargesInformation;
    IBranchAndFinancialInstitutionIdentification3? IPaymentTransactionInformation5.InstructingAgent => InstructingAgent;
    IBranchAndFinancialInstitutionIdentification3? IPaymentTransactionInformation5.InstructedAgent => InstructedAgent;
    IEnumerable<IReversalReasonInformation1> IPaymentTransactionInformation5.ReversalReasonInformation => ReversalReasonInformation;
    IOriginalTransactionReference1? IPaymentTransactionInformation5.OriginalTransactionReference => OriginalTransactionReference;
}
